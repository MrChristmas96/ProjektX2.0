using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject pointDrop;

    public int enemyHealth = 100;

    public ParticleSystem hit;
    private ParticleSystem hitPlay;


    private void Awake()
    {
        hitPlay = null;    
    }

    private void Update()
    {
        if (enemyHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }


    //Disable og ikke destroy så vi kan efterlade lig på banen.
    private void OnDisable()
    {
        // Fixer error "Some objects were not cleaned up when closing the scene" så den kun instantiater hvis scener er loaded
        if (!this.gameObject.scene.isLoaded) return;

    }

    public void TakeDamage(int i)
    {
        HitEffect(hit);
        enemyHealth -= i;
    }
    
    public void HitEffect(ParticleSystem hit)
    {
        //Gemmer hit particleSystem som en variabel
        if (hitPlay == null)
        {
            hitPlay = Instantiate(hit, transform.position, Quaternion.identity);
        }

        hitPlay.Play();
    }
}
