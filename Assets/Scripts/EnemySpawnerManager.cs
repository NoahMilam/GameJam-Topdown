using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{
    [SerializeField] LevelSpawner level;
    [SerializeField] EnemySpawner [] SpawnDoors;

    private WaveData CurrnetwaveData;
    private int currentWaveNumber = 0;

    private List<GameObject> Enemies;
    // Start is called before the first frame update
    void Start()
    {
        Enemies = new List<GameObject>();
        WaveSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void WaveSetup() {
        SetCurrentWave();
        SpawnWave();
    }

    private void SetCurrentWave() {
        CurrnetwaveData = level.wave[currentWaveNumber];
        currentWaveNumber++;
    }

    private void SpawnWave() {
        List<GameObject> tempList = new List<GameObject>();
        for (int i = 0; i < SpawnDoors.Length ; i++) {
            tempList =  SpawnDoors[i].SpawnEnemys(CurrnetwaveData.Enemies[0], CurrnetwaveData.nesw[i]);
        }
        Enemies.AddRange(tempList);
    }

    public void RemoveEnemy(GameObject enemy) 
    {
        Enemies.Remove(enemy);
        if (Enemies.Count <= 0) {
            EndWave();
        }
    }

    private void EndWave() {
        // check if last wave
        if (level.wave.Count <= currentWaveNumber) {
            Debug.Log("last wave");
        }
#warning hack in place
        SpawnWave();
    }
}
