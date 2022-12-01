using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSize : MonoBehaviour
{
    public void ScaleEnter()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.2f, 1f).setEaseInBounce();
    }

    public void ScaleExit()
    {
        LeanTween.cancel(gameObject);
        LeanTween.scale(gameObject, Vector3.one, 0.25f).setEaseOutBack();
    }

}
