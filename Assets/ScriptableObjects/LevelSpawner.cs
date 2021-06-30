using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelWaveData", menuName = "Bodacious/LevelWaveData", order = 1)]
public class LevelSpawner : ScriptableObject
{
    public List<WaveData> wave;
}

[System.Serializable]
public class WaveData {
    public List<GameObject> Enemies;
    public float secondsBeforWave;
    public int[] nesw = new int[4];
}