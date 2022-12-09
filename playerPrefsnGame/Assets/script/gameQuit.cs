using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameQuit : MonoBehaviour
{
    public void clickBack()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
