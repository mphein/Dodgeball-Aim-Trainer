using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject[] enemies;

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                return;
            }
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameEnd();

    }

    public void GameEnd()
    {
        SceneManager.LoadScene("GameOver");
    }
}
