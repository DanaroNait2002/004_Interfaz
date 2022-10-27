using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu, optionsCanvas, tittle, language, button01, button02, back;

    public void click_MainMenu()
    {
        LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);
    }

    public void click_Back()
    {
        LeanTween.alphaCanvas(optionsCanvas.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Enabled);
    }

    public void Disabled()
    {
        mainMenu.SetActive(false);
        optionsCanvas.SetActive(true);
        LeanTween.alphaCanvas(optionsCanvas.GetComponent<CanvasGroup>(), 1.0f, 0.75f).setOnComplete(Tittle);
    }

    public void Enabled()
    {
        optionsCanvas.SetActive(false);
        mainMenu.SetActive(true);
        LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }


    public void Tittle()
    {
        LeanTween.scale(tittle, Vector3.one, 1f).setEaseOutBack().setOnComplete(Language);
    }

    public void Language()
    {
        LeanTween.scale(language, Vector3.one, 1f).setEaseOutBack().setOnComplete(Button01);
    }

    public void Button01()
    {
        LeanTween.scale(button01, Vector3.one, 1f).setEaseOutBack().setOnComplete(Button02);
    }

    public void Button02()
    {
        LeanTween.scale(button02, Vector3.one, 1f).setEaseOutBack().setOnComplete(Back);
    }

    public void Back()
    {
        LeanTween.scale(back, Vector3.one, 1f).setEaseOutBack();
    }
}