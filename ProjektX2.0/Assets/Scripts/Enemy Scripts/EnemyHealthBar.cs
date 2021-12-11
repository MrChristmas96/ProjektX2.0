using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealthBar : MonoBehaviour
{

    private Image HealthBar;
    public float currentHealth;
    private float MaxHealth;
    private EnemyController enemy;
    public Transform fill;

    private void Start()
    {
        HealthBar = fill.GetComponent<Image>();
        enemy = GetComponent<EnemyController>();
        MaxHealth = enemy.enemyHealth;
    }

    private void Update()
    {
        currentHealth = enemy.enemyHealth;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }

}


