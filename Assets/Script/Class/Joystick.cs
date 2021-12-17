using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    // Init
    protected Image container;
    protected Image joystick;
    protected Vector3 InputDirection = Vector3.zero;

    public void OnDrag(PointerEventData ped)
    {
        Vector2 position = Vector2.zero;

        // Get InputDirection
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            container.rectTransform,
            ped.position,
            ped.pressEventCamera,
            out position
        );

        float x = (position.x / container.rectTransform.sizeDelta.x);
        float y = (position.y / container.rectTransform.sizeDelta.y);

        InputDirection = new Vector3(x, y, 0);
        InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;

        // Define the area in which joystick can move around
        joystick.rectTransform.anchoredPosition = new Vector3(
            InputDirection.x * container.rectTransform.sizeDelta.x / 3,
            InputDirection.y * container.rectTransform.sizeDelta.y / 3
        );
    }

    public void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public void OnPointerUp(PointerEventData ped)
    {
        InputDirection = Vector3.zero;
        joystick.rectTransform.anchoredPosition = Vector3.zero;
    }
}