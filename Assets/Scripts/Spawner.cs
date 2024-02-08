using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] myEnemies;
    // Start is called before the first frame update

    public GameObject SpawnEnemies()
    {
        int spawnPointX = Random.Range(-10, 10);
        int spawnPointZ = Random.Range(-10, 10);

        Vector3 spawnPosition = new Vector3(spawnPointX, 1, spawnPointZ);
        GameObject enemy = Instantiate(myEnemies[Random.Range(0,myEnemies.Length)], spawnPosition, Quaternion.identity);
        return enemy;
    }
}
