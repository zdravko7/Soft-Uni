using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiManager : MonoBehaviour 
{
    public GameObject playerDeadLbl;
    public Text scoreLbl;

    public void OnHomeClicked()
    {
        Application.LoadLevelAsync("MenuScene");
    }

    public void ShowDeadText()
    {
        playerDeadLbl.SetActive(true);
    }
}
