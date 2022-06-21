using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;

    // Start is called before the first frame update
    // Setting maxHealth to maxhealth based on healthlevel while setting current health at the start of the level to max health and letting healthbar reflect that
    void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        
    }
    // Arbitrary number play around with it to find a good value
    private int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }
    // Sets current health based on damage taken and reflects that damage on healthbar
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth < 1)
            Death();
    }

    private void Death()
    {
        gameObject.SetActive(false);
    }
}
