using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject pointDrop;

    public int enemyHealth = 100;

    private void Update()
    {
        if (enemyHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }


    //Disable og ikke destroy s� vi kan efterlade lig p� banen.
    private void OnDisable()
    {
        // Fixer error "Some objects were not cleaned up when closing the scene" s� den kun instantiater hvis scener er loaded
        if (!this.gameObject.scene.isLoaded) return;
 
        Instantiate(pointDrop, transform.position, Quaternion.identity);
    }

    public void TakeDamage()
    {
        enemyHealth -= 50;
    }
}
