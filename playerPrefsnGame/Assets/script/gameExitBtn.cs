using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameExitBtn : MonoBehaviour
{
    public void clickExit()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void clickYesGame()
    {
        SceneManager.LoadScene("gameScene");
    }
}
