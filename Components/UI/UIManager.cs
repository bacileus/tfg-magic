using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private LifeReceiver lifeReceiver;
    [SerializeField] private Slider healthSlider;
    private static UIManager s_instance;

    public static UIManager instance
    {
        get
        {
            return s_instance;
        }
    }

    void Awake()
    {
        s_instance = this;

        healthSlider.maxValue = lifeReceiver.getEntityDef().getMaxHP();
        healthSlider.value = healthSlider.maxValue;
    }
    
    public void setHealth(int health) {
        healthSlider.value = health;
    }

    public void quit() {
        Application.Quit();
    }
}
