using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public GameObject target;
    public Health targetHealth;
    public int targetMaxHealth;


    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        targetHealth = target.GetComponent<Health>();
        SetCurrentHealth(targetHealth.currentHealth);

    }
    private void Start()
    {
        //targetMaxHealth = targetHealth.maxHealth;
        //slider.maxValue = targetHealth.maxHealth;
        SetMaxHealth(targetHealth.maxHealth);
        SetCurrentHealth(targetHealth.maxHealth);

    }
    private void Update()
    {
        SetCurrentHealth(targetHealth.currentHealth);
    }

    // Setting values of slider to Max and current value of Health
    public void SetMaxHealth(int MaxHealth)
    {
        slider.maxValue = MaxHealth;
        slider.value = MaxHealth;

    }
    // Setting the slider on Healthbar to current Health
    public void SetCurrentHealth(int currentHealth)
    {
        slider.value = currentHealth;
        
    }

}
