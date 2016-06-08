using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public delegate void PauseGame();

public class PlayerLogicScript : MonoBehaviour
{
    public event PauseGame pauseGame;
    public Text scoreText;

	void Start ()
    {
        //add the existing subscriber to the event
        GameObject existingPlatform = GameObject.FindGameObjectWithTag("smallPlatform");

        if (existingPlatform != null)
        {
            pauseGame += existingPlatform.GetComponent<PlatformScript>().PauseGame;
        }
	}

    public void UpdateScore(int value)
    {
        scoreText.text = "" + value;
    }

    public void OnPauseClicked()
    {
        pauseGame.Invoke();
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }

}
