using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarP2 : MonoBehaviour
{

    private Image HealthBar;
    public float currentHealth;
    private float MaxHealth;
    GameMaster GM;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        GM = FindObjectOfType<GameMaster>();
        MaxHealth = GM.p2Health;
    }

    private void Update()
    {
        currentHealth = GM.p2Health;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }

}


