using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyManager : MonoBehaviour
{
    public float enemyHealth;
    public TMPro.TextMeshProUGUI health;

    private void Start()
    {
        if(this.gameObject.name == "Big Enemy")
        {
            enemyHealth = 500;
        }
        else        enemyHealth = Random.Range(100, 251);
    }
    private void Update()
    {
        health.text = enemyHealth.ToString();
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
