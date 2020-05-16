using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    public void setHealth(int health)
    {
        slider.value = health;
    }

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void subtractHealth(int difference)
    {
        slider.value = slider.value - difference;
        if (slider.value < 0)
        {
            slider.value = 0;
        }
    }
}
