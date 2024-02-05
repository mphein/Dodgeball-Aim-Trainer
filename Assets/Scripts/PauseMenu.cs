using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;
    public GameObject onScreenUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (!paused)
            {
                Pause();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Resume();
            }
        }
        
    }

    public void Resume()
    {
        onScreenUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        paused = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        onScreenUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        paused = true;
        Time.timeScale = 0f;
    }
}
