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
        public static int count = 4;
        public float rate;

    }

    public Transform enemy;

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;


    public float timeBetweenWaves = 5f;
    private float waveCountDown;

    private float searchCountDown = 1f;

    public SpawnState state = SpawnState.COUNTING;

    public int enemyP1 = 0;
    public int enemyP2 = 0; 

    private void Start()
    {
        waveCountDown = timeBetweenWaves;

    }

    private void Update()
    {
        if (enemyP1 > 0)
        {
            SpawnSendEnemyP1();
            Debug.Log("Send EnemyP1");
        }

        if (enemyP2 > 0)
        {
            SpawnSendEnemyP2();
            Debug.Log("Send EnemyP2");
        }

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

        if (nextWave + 1 > waves.Length - 1) //Hvis nextWave er størrer end 0 begynder den at spawne flere fjender
        {
            Debug.Log("Adding more enemies");
            Wave.count += 2;
           
            nextWave = 0;
            
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
        Debug.Log("Spawning wave " + _wave.name);
        state = SpawnState.SPAWNING;
        for (int i=0; i< Wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);

            //lille delay på at spawne fjender lige efter hinanden
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

    void SpawnSendEnemyP1()
    {
        for (int i = 0; i < enemyP1; i++)
        {
            Transform _sp = spawnPoints[Random.Range(2, 4)];
            Instantiate(enemy, _sp.position, _sp.rotation);
            Debug.Log("SpawnSendEnemy");
            enemyP1--;
        }
    }
    void SpawnSendEnemyP2()
    {
        for (int i = 0; i < enemyP2; i++)
        {
            Transform _sp = spawnPoints[Random.Range(0, 2)];
            Instantiate(enemy, _sp.position, _sp.rotation);
            Debug.Log("SpawnSendEnemy");
            enemyP2--;
        }
    }



}
