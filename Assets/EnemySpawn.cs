using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public int timeToSpawn;
    public int enemyType;
    public Transform SpawnPosition;
    

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, timeToSpawn);
    }

    private void Update() {
        
    }

    public void SpawnEnemy()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-15.0f,15.0f),SpawnPosition.position.y, SpawnPosition.position.z);

        GameObject enemy = PoolManager.instance.GetPooledObject(1);
        enemy.transform.position = SpawnPos;
        enemy.SetActive(true);
    }
}
