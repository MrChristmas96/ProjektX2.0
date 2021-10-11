using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    [System.Serializable] //Allows us to change the value of variables in Unity

    
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;

    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private float waveCountDown;

    private float searchCountDown = 1f;

    public SpawnState state = SpawnState.COUNTING;

    private void Start()
    {
        waveCountDown = timeBetweenWaves;

    }

    private void Update()
    {
        if (state == SpawnState.WAITING)
        {
            //Check om der er fjender i live
            if (!EnemyIsAlive())
            {
                //Begin new wave
                WaveCompleted();
                return;
            }
            else
            {
                return;
            }
        }

        if (waveCountDown >= 0)
        {
            
            if (state != SpawnState.SPAWNING)
            {
                //Hvis ikke vi er igang med at spawn, spawn wave
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
            else
            {
                waveCountDown -= Time.deltaTime;
            }
        }
    }

    void WaveCompleted()
    {
        Debug.Log("Wave completed");

        state = SpawnState.COUNTING;
        waveCountDown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1) 
        {
            nextWave = 0;
            Debug.Log("All waves complete");
        }
        else
        {
            nextWave++;
        }

        

    }

    bool EnemyIsAlive()
    {
        //Hver searchCountDown ser vi om der er et object i live med tagget "Enemy"
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0f)
        {
            searchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
            
        }
        return true;
    }

    IEnumerator SpawnWave (Wave _wave)
    {
        Debug.Log("Spawning wave" + _wave.name);
        state = SpawnState.SPAWNING;
        for (int i=0; i< _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);

            //Vent med at spawn flere fjender
            yield return new WaitForSeconds (1f / _wave.rate) ;
        }


        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnEnemy (Transform _enemy)
    {
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
        Debug.Log("Spawn" + _enemy.name);
    }

}
