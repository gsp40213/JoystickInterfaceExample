網站教學如下: 
1. https://gsp40213.pixnet.net/blog/post/231474421-joystick-layout-for-unity3d
2. https://unityblenderskillbook.blogspot.com/2021/12/joystick-layout-for-unity3d.html
---------------------------------------------------------------
Joystick腳本可以直接丟到物件上面，但是要寫需更改。

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler{
    public Vector3 InputDirection = Vector3.zero;

    void Start(){
        container = GetComponent<Image>();
        joystick = transform.GetChild(0).GetComponent<Image>();
    }
}
