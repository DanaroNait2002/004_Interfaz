using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, player;

    [SerializeField]
    TMP_InputField inputNickname;

    [SerializeField]
    TMP_Text textNickname, errorlog;



    void Start()
    {
        screenGame.SetActive(false);
        screenIntro.SetActive(true);
        player.SetActive(false);
    }

    public void StartGame()
    {
        if (string.IsNullOrEmpty(inputNickname.text))
        {
            errorlog.text = "Insert an User Name!";
        }
        else
        {
            screenGame.SetActive(true);
            screenIntro.SetActive(false);
            player.SetActive(true);

            textNickname.text = inputNickname.text;
        }
    }

}
