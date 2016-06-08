using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    public void OnPlayClicked()
    {
        Application.LoadLevel("GameScene");
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
