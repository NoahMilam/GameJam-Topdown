using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    List<Transform> SpawnPoints;

    private void Start()
    {
        SpawnPoints = new List<Transform>();
        foreach (Transform child in transform) 
        {
            SpawnPoints.Add(child);
        }
    }

    public List<GameObject> SpawnEnemys(GameObject enemyPrefab, int number) {

        List<Transform> randomList = SpawnPoints.OrderBy(i => Random.value).ToList();
        List<GameObject> enemiesTemp = new List<GameObject>();
        for (int i = 0; i < number; i++) {
            int child = i % randomList.Count;
            Transform spawnPoint = randomList[child];
            // subscripbe to es manager
            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            enemiesTemp.Add(enemy);
        }

        return enemiesTemp;
    }
}
