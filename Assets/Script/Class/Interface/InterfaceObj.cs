using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InterfaceObj : interfaceObj
{
    public void button(Button button, float pointX, float pointY, float sizeX, float sizeY, UnityAction onClick)
    {
        try
        {
            button.transform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
            button.image.rectTransform.sizeDelta = new Vector2(Screen.width / 2 * sizeX, sizeY);
            button.onClick.AddListener(onClick);
        }
        catch { }
    }

    public void image(Image image, float pointX, float pointY, float sizeX, float sizeY)
    {
        try
        {
            image.rectTransform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
            image.rectTransform.sizeDelta = new Vector2(Screen.width / 2 * sizeX, Screen.height / 2 * sizeY);
        }
        catch { }
    }
}