using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public int planeCount;
    public int tankCount;
    public int soldierCount;
    public int jeepCount;

    public GameObject tank;
    public float timeBetweenWaves = 5f;
    public float countdown = 2f;
    private int waveNumber = 1;
    public Transform spawnPoint;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }
    void SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
        waveNumber++;
    }
    void SpawnEnemy()
    {
        Instantiate(tank, this.transform.position, this.transform.rotation);
    }

}
