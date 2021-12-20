using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpawner : MonoBehaviour
{

    public Transform enemy;
    private bool canSpawn;

    void Start()
    {
        canSpawn = true;
    }

    void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(Spawn());
            canSpawn = false;
        }
       
    }

    IEnumerator Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3.5f);
        canSpawn = true;
    }
}
