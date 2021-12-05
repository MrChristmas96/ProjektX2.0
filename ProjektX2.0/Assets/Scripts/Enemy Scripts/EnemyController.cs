using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemyController : MonoBehaviour
{

    public GameObject pointDrop;

    public int enemyHealth = 100;

    public ParticleSystem hit;
    public ParticleSystem blood;
    private ParticleSystem hitPlay;
    private ParticleSystem bloodPlay;


    private void Awake()
    {
        hitPlay = null;
        bloodPlay = null;
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
        Instantiate(pointDrop, transform.position, Quaternion.identity);
    }

    public void TakeDamage(int i)
    {
        transform.position = transform.position + new Vector3(0, 1, 0);
        HitEffect(hit);
        BloodEffect(blood);
        enemyHealth -= i;
        Thread.Sleep(20);
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

    public void BloodEffect(ParticleSystem blood)
    {
        if (bloodPlay == null)
        {
            bloodPlay = Instantiate(blood, transform.position, Quaternion.identity);
        }
        blood.Play();
    }
}
