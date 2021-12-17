using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layout_Main : Joystick
{
    public Image fixedJoystick_image, handle_image;
    public Button jump_btn;

    InterfaceOBJ fixedJoystick, jump;

    public static Vector3 DIRCTION;
    public static bool JUMP_SW;

    // 計時器
    private float timeCount;
    private float timeCD = 1f;

    public static bool JUMP_ACTIVE;

    private void Start()
    {
        base.container = fixedJoystick_image;
        base.joystick = handle_image;

        fixedJoystick = new InterfaceOBJ(fixedJoystick_image, new InterfaceObj());
        fixedJoystick.image(0.23f, 0.4f, 0.2f, 0.35f);

        jump = new InterfaceOBJ(jump_btn, new InterfaceObj());
        jump.button(1.68f, 0.42f, 0.2f, 80, jump_onClkck);
    }

    private void Update()
    {
        DIRCTION = base.InputDirection;
        JUMP_ACTIVE = jumpCd();
    }

    void jump_onClkck()
    {
        if (JUMP_ACTIVE == true)
        {
            JUMP_SW = true;
            timeCount = timeCD;
        }
    }

    // 跳躍冷卻時間
    public bool jumpCd()
    {
        return ((timeCount -= Time.deltaTime) <= 0) ? true : false;
    }
}