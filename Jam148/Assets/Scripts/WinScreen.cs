using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinScreen : MonoBehaviour
{ 
    public bool Complete;
    public GameObject Win;
    public static float endTime;
    private float currentTime;
    public TextMeshProUGUI thisTimeText;
    public TextMeshProUGUI bestTimeText;
    private float bestTime;
    public TextMeshProUGUI NewHighScore;

    //public TriggerEnd TE;

    public void Start()
    {
        currentTime = Time.time;
        bestTime = PlayerPrefs.GetFloat("BestTime", 0);

    }

    public void Update()
    {
        if (Win.activeSelf) {
            Complete = true;
            Time.timeScale = 0f;
        }
        if (Complete == false)
        {
            //Update the timer
            endTime = Time.time;
        }
        else if (Complete == true)
        {
            //Calculate the amount of time it took to complete the objective (Saved Variable)
            //endTime = endTime;
            endTime = endTime - currentTime;
            thisTimeText.text = "Your time: " + endTime;

            if (endTime < bestTime)
            {
                NewHighScore.gameObject.SetActive(true);
                PlayerPrefs.SetFloat("BestTime", endTime);
                bestTimeText.text = "Best time: " + endTime;
            }
            else {
                bestTimeText.text = "Best time: " + bestTime;
            }
        }
    }

    
    public void PlayAgain ()
    {
        Win.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu() {
        Time.timeScale = 1f;
        Win.SetActive(false);
        SceneManager.LoadScene("MainMenu");
        
    }

    public void Quit()
    {
        Win.SetActive(false);
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    

}
