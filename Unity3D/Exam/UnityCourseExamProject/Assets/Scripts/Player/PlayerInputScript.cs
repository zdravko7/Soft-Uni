using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerInputScript : MonoBehaviour 
{
    Transform playerTransform;
    Transform currentSmallPlatform;
    Rigidbody2D playerRigidBody;
    bool isGamePaused;
    bool isOnSmallPlatform;
    int score;
    PlayerControlScript playerControlScript;
    PlayerLogicScript playerLogicScript;

	private void Start()
    {
        playerTransform = this.transform;
        playerRigidBody = playerTransform.GetComponent<Rigidbody2D>();
        playerControlScript = GetComponent<PlayerControlScript>();
        playerLogicScript = GetComponent<PlayerLogicScript>();
        playerLogicScript.pauseGame += PauseGame;
        AudioManager.InitAudioManager(); 
	}

    private void Update()
    {
        UpdatePlayerInput();
        UpdateSmallPlatformState();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("smallPlatform") || collision.collider.tag.Equals("platform"))
        {
            playerControlScript.playerState = PlayerState.Running;
        }

        if (collision.collider.tag == "smallPlatform")
        {
            if (!isOnSmallPlatform)
            {
                isOnSmallPlatform = true;
            }

            if (currentSmallPlatform != collision.transform)
            {
                currentSmallPlatform = collision.transform;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "smallPlatform")
        {
            if (isOnSmallPlatform)
            {
                isOnSmallPlatform = false;
            }

            playerControlScript.platformDelta = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            score++;
            PlayerPrefs.SetInt("HighScore", score);
            playerLogicScript.UpdateScore(score);
            AudioManager.PlayAudioSound(AudioSounds.CollectCoin, false);
            Destroy(col.gameObject);
        }
        else if (col.tag == "platform")
        {
            SceneManager.LoadScene("GameScene");
            PlayerPrefs.SetInt("HighScore", 0);
        }

    }

    private void UpdateSmallPlatformState()
    {
        if(!isOnSmallPlatform || isGamePaused)
        {
            return;
        }

        playerControlScript.platformDelta = currentSmallPlatform.GetComponent<Rigidbody2D>().velocity.x;
        
    }

    private void UpdatePlayerInput()
    {
        if (isGamePaused)
        {
            return;
        }

        if (playerControlScript.playerState != PlayerState.Dead)
        {
            float horizontalIncrement = GetHorizontalInput();

            if (playerControlScript.playerState == PlayerState.Jumping)
            {
                horizontalIncrement *= 2f;
            }
            
            if (horizontalIncrement != 0f)
            {
                if (playerControlScript.playerState == PlayerState.Idle)
                {
                    playerControlScript.playerState = PlayerState.Running;
                }

                playerControlScript.MovePlayer(horizontalIncrement);
            }
            else if (playerControlScript.playerState == PlayerState.Running)
            {
                playerControlScript.manageAnimations.PlayCharactherAnimation(PlayerAnimations.Idle, true, true);
                playerControlScript.playerState = PlayerState.Idle;
            }
        }

        if (GetVerticalInput())
        {
            playerControlScript.Jump();
        }

    }

    private bool GetVerticalInput()
    {
        if (isGamePaused)
        {
            return false;
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private float GetHorizontalInput()
    {
        if (isGamePaused)
        {
            return 0f;
        }

        return Input.GetAxis("Horizontal");
    }

    private void PauseGame()
    {
        isGamePaused = !isGamePaused;
        playerRigidBody.isKinematic = !playerRigidBody.isKinematic;
        
    }
}

public enum PlayerState
{
    Idle,
    Running,
    Jumping,
    Dead
}