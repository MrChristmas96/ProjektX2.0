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
        MaxHealth = enemy.currentEnemyHealth;
    }

    private void Update()
    {
        currentHealth = enemy.currentEnemyHealth;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }

}


