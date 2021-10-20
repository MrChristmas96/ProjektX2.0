using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject pointDrop;

    public int health;

    void Start()
    {
        
    }

    private void OnDisable()
    {
        // Fixer error "Some objects were not cleaned up when closing the scene" så den kun instantiater hvis scener er loaded
        if (!this.gameObject.scene.isLoaded) return;
 
        Instantiate(pointDrop, transform.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
