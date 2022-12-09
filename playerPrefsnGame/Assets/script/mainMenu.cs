using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void clickProfile()
    {
        SceneManager.LoadScene("profileScene");
    }
    public void clickGame()
    {
        SceneManager.LoadScene("gameScene");
    }
    public void clickBack()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    
}
