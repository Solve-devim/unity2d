using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    public void PlayButton()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}