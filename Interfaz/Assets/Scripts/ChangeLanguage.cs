using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    int idiomaActual = 0;
    int IDIOMASTOTALES;

    void SelectCurrentLanguage()
    {
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[idiomaActual];

        //Mientras el idioma que esta funcionando no es el que estoy revisando
        //Miro el siguiente
        while (searcher != LocalizationSettings.SelectedLocale && idiomaActual < LocalizationSettings.AvailableLocales.Locales.Count)
        {
            idiomaActual++;
            searcher = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
        }
    }

    void Awake()
    {
        /*
        Array con los diferentes idiomas que tiene el juego configurado
        LocalizationSettings.AvailableLocales.Locales
        Idiomas = {Espa�ol, Ingl�s, Franc�s, Alem�n, Italiano...}

        El idioma que se esta utilizando 
        LocalizationSettings.SelectedLocale

        int idiomaAleatorio = Random.Range(0, 3); //Genero n�mero aleatorio

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];

        Total de idiomas
        int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
        */
    }

    private void Start()
    {
         IDIOMASTOTALES = LocalizationSettings.AvailableLocales.Locales.Count;
        //Idiomas = {Espa�ol, Ingl�s, Franc�s, Alem�n, Italiano...}
        SelectCurrentLanguage();
    }

    public void ClickPrevious()
    {
        idiomaActual -= 1;

        if (idiomaActual < 0)
        {
            idiomaActual = 4;
        }

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
    }

    public void ClickNext()
    {
        idiomaActual += 1;

        if (idiomaActual >= IDIOMASTOTALES)
        {
            idiomaActual = 0;
        }

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
    }
}
