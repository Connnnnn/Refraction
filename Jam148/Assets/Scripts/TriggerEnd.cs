using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{

    public GameObject WinScreen;
    public static bool GameIsOver = false;


    private void OnTriggerEnter(Collider other)
    {
        WinScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0f;

        GameIsOver = true;

    }

    
}
