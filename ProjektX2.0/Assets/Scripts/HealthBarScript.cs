using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarScript : MonoBehaviour
{
    
    public Image healthBar;
    float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    public void Start() {
        healthBar = GetComponent<Image> ();
        health = maxHealth;
    }

    // Update is called once per frame
    public void Update() {
        healthBar.fillAmount = health / maxHealth;
    }
}