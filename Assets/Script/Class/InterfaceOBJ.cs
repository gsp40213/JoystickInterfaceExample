using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InterfaceOBJ
{
    private Image imageObj;
    private Button buttonObj;
    private interfaceObj interfaceObj;

    public InterfaceOBJ(Image imag, interfaceObj interfaceObj)
    {
        this.imageObj = imag;
        this.interfaceObj = interfaceObj;
    }

    public InterfaceOBJ(Button button, interfaceObj interfaceObj)
    {
        this.buttonObj = button;
        this.interfaceObj = interfaceObj;
    }

    // image
    public void image(float pointX, float pointY, float sizeX, float sizeY)
    {
        interfaceObj.image(imageObj, pointX, pointY, sizeX, sizeY);
    }

    // button
    public void button(float pointX, float pointY, float sizeX, float sizeY, UnityAction onClick)
    {
        interfaceObj.button(buttonObj, pointX, pointY, sizeX, sizeY, onClick);
    }
}

public interface interfaceObj
{
    void image(Image image, float pointX, float pointY, float sizeX, float sizeY);
    void button(Button button, float pointX, float pointY, float sizeX, float sizeY, UnityAction onClick);
}
