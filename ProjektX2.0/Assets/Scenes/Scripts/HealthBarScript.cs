using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;
    
    // Start is called before the first frame update
    void Start() {
        healthBar = GetComponent<Image> ();
        public static float health;
    }

    // Update is called once per frame
    void Update() {
        healthBar.fillAmount = health / maxHealth;
    }
}
