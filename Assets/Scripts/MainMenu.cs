using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void BacktoMenu()
    {
        Debug.Log("CLICKED!!!");
        SceneManager.LoadScene("MainMenu");
    }

}
