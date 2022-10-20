using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField]
    int MAX_HEALTH = 20;

    [SerializeField]
    Slider sliderHealth;


    void Start()
    {
        sliderHealth.maxValue = MAX_HEALTH;
        sliderHealth.value = MAX_HEALTH / 2;
    }

    public void Health(int valor)
    {
        sliderHealth.value += valor;
    }

}
