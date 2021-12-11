using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarScript : MonoBehaviour
{

    private Image HealthBar;
    public float currentHealth;
    private float MaxHealth;
    GameMaster GM;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        GM = FindObjectOfType<GameMaster>();
        MaxHealth = GM.p1Health;
    }

    private void Update()
    {
        currentHealth = GM.p1Health;
        HealthBar.fillAmount = currentHealth / MaxHealth;
    }

}


