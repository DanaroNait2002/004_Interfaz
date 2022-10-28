using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logoImage, buttonsImage, subtittleImage, button01, button02, button03, button04, flag;



    private void OnEnable()
    { 
        //Mover los Cuadros principales fuera de rango
        LeanTween.moveLocalX(logoImage, -1500f, 0.0f);
        LeanTween.moveLocalX(buttonsImage, 1500f, 0.0f);
        LeanTween.moveLocalX(subtittleImage, -1500, 0.0f);

        //Entrar en pantalla
        LeanTween.moveLocalX(logoImage, -450f, 2.0f).setEaseSpring().setOnComplete(Beat_logoImage);
        LeanTween.moveLocalX(buttonsImage, 680f, 2.0f).setEaseSpring().setOnComplete(Beat_buttonsImage);
    }


    //Funciones de Beat Imágenes principales
    void Beat_logoImage()
    {
        LeanTween.scale(logoImage, Vector3.one, 0.25f).setEaseOutBack();
        LeanTween.moveLocalX(subtittleImage, -450, 2.5f).setEaseSpring().setOnComplete(Beat_subtittleImage);
    }

    void Beat_subtittleImage()
    {
        LeanTween.scale(subtittleImage, Vector3.one, 1f).setEaseOutBack().setLoopPingPong();
    }

    void Beat_buttonsImage()
    {
        LeanTween.scale(buttonsImage, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(Beat_button01);
    }


    //Funciones de Beat Botones
    void Beat_button01()
    {
        LeanTween.scale(button01, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(Beat_button02);
    }

    void Beat_button02()
    {
        LeanTween.scale(button02, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(Beat_button03);
    }

    void Beat_button03()
    {
        LeanTween.scale(button03, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(Beat_button04);
    }

    void Beat_button04()
    {
        LeanTween.scale(button04, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(Beat_Flag);
    }

    void Beat_Flag()
    {
        LeanTween.scale(flag, Vector3.one, 0.25f).setEaseOutBack();
    }
}
