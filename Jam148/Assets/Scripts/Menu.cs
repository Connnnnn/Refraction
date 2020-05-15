using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("MenuSong");

    }

    //Main menu script for starting game
    public void PlayGame()
    {
        Debug.Log("Play!");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game Scene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
