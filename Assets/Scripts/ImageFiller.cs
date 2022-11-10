using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFiller : MonoBehaviour
{
    Image image;
    

    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    //Lo que hizo el profe
    public void Life(float valor)
    {
        image.fillAmount += valor;
    }


    /*
     *Lo que hice yo xD
    public void Fill() 
    {
        image.fillAmount += 0.05f;
    }

    public void Empty()
    {
        image.fillAmount -= 0.05f;
    }
    */
}
