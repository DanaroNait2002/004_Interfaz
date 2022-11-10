using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo, mainMenu;


    void Start()
    {
        //Oculto mi logo. De manera inmediata
        LeanTween.moveLocalY(logo, -1000f, 0.0f);

        //Hago aparecer el logo desde su posición
        //Animación que dura 1.0f
        LeanTween.moveLocalY(logo, 0f, 2.0f).setEaseSpring().setOnComplete(Beat);

        //Para moverlo en ambos ejes
        //LeanTween.moveLocal(logo, new Vector3 (450f, 0.0f, 0.0f), 2.0f;

        void Beat()
        {
            LeanTween.scale(logo, Vector3.one, 0.25f).setEaseOutBack().setOnComplete( () => {
                LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);

            });
        }

        void Disabled()
        {
            gameObject.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}
