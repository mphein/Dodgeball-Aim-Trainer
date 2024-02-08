using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager _instance;

    public List<GameObject> enemies;

    public Spawner spawner;

    public static EnemyManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < enemies.Count; i++)
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

    IEnumerator SpawnCoroutine()
    {
        for (int i = 0; i < 15; i++)
        {
            GameObject currEnemy = spawner.SpawnEnemies();
            enemies.Add(currEnemy);
            yield return new WaitForSeconds(3f);
        }
    }
}
