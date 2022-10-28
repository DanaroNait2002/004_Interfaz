using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    int idiomaActual = 0;
    int IDIOMASTOTALES;


    void Awake()
    {
        /*
        Array con los diferentes idiomas que tiene el juego configurado
        LocalizationSettings.AvailableLocales.Locales
        Idiomas = {Español, Inglés, Francés, Alemán, Italiano...}

        El idioma que se esta utilizando 
        LocalizationSettings.SelectedLocale

        int idiomaAleatorio = Random.Range(0, 3); //Genero número aleatorio

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaAleatorio];

        Total de idiomas
        int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
        */
    }

    private void Start()
    {
         IDIOMASTOTALES = LocalizationSettings.AvailableLocales.Locales.Count;
        //Idiomas = {Español, Inglés, Francés, Alemán, Italiano...}
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
