using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthPerLevel = 10;
    public int maxHealth;
    public int currentHealth;
    public int level = 1;

    // Start is called before the first frame update
    // Setting maxHealth to maxhealth based on healthlevel while setting current health at the start of the level to max health and letting healthbar reflect that
    void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel(level);
        currentHealth = maxHealth;
        
    }
    // Arbitrary number play around with it to find a good value
    private int SetMaxHealthFromHealthLevel(int level)
    {
        maxHealth = healthPerLevel * level;
        return maxHealth;
    }
    // Sets current health based on damage taken
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //if (currentHealth < 1)
            //Death();

    }
    private void Death()
    {
        this.gameObject.SetActive(false);
    }
    
    
}
