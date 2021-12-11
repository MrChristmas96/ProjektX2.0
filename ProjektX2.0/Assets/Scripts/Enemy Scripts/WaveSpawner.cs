using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    [System.Serializable] //Allows us to change the value of variables in Unity

    
    public class Wave
    {
        public Transform enemy;
        public static int count = 4;
        public float rate;
    }

    public Transform enemy;

    public Wave[] waves;
    private int nextWave = 0;
    public int waveCount = 1;


    public Transform[] spawnPoints;


    public float timeBetweenWaves = 5f;
    private float waveCountDown;

    private float searchCountDown = 1f;

    public SpawnState state = SpawnState.COUNTING;

    public int enemyP1 = 0;
    public int enemyP2 = 0;

    private float spawnSendP1;
    private float spawnSendP2;

    public UIMaster UIMaster;

    private void Start()
    {
        waveCountDown = timeBetweenWaves;

    }

    private void Update()
    {
        if (Time.time > spawnSendP1 && enemyP1 > 0)
        {
            SpawnSendEnemyP1();
        }

        if (Time.time > spawnSendP2 && enemyP2 > 0)
        {
            SpawnSendEnemyP2();
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
            Wave.count += 2;
            waveCount++;
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
        UIMaster.WaveStart();
        Debug.Log("Wave: "+ waveCount);
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
        enemy.tag = "EnemyP1";
        Transform _sp = spawnPoints[Random.Range(2, 4)];
        Instantiate(enemy, _sp.position, _sp.rotation);
        enemyP1--;
        spawnSendP1 = Time.time + Random.Range(0.2f, 1.2f);
        enemy.tag = "Enemy";
    }

    void SpawnSendEnemyP2()
    {
        enemy.tag = "EnemyP2";
        Transform _sp = spawnPoints[Random.Range(0, 2)];
        Instantiate(enemy, _sp.position, _sp.rotation);
        enemyP2--;
        spawnSendP2 = Time.time + Random.Range(0.2f, 1.2f);
        enemy.tag = "Enemy";
    }



}
