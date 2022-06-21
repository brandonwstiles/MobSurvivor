using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public Slider slider;

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
