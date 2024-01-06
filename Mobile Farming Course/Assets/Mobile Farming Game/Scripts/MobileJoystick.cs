using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileJoystick : MonoBehaviour
{
  [Header("Elements")]
  [SerializeField] private RectTransform joyStickOutline;
  [SerializeField] private RectTransform joyStickKnob;

  [Header("Settings")]
  [SerializeField] private float moveFactor;
  private bool canControl;
  Vector3 clickedPosition;
  Vector3 currentPosition;
  Vector3 direction;
  Vector3 move;
  Vector3 targetPosition;
  float moveMagnitude;
  private void Start()
  {
    HideJoystick();
  }

  private void Update()
  {
    if (canControl)
    {
      ControlJoystick();
    }
  }

  public void ClickedOnJoyStickZoneCallback()
  {
    clickedPosition = Input.mousePosition;
    joyStickOutline.position = clickedPosition;

    ShowJoystick();
  }

  private void ShowJoystick()
  {
    joyStickOutline.gameObject.SetActive(true);
    canControl = true;
  }
  private void HideJoystick()
  {
    joyStickOutline.gameObject.SetActive(false);
    canControl = false;

    move = Vector3.zero;
  }

  private void ControlJoystick()
  {
    currentPosition = Input.mousePosition;
    direction = currentPosition - clickedPosition;

    moveMagnitude = direction.magnitude * moveFactor / Screen.width;
    moveMagnitude = Mathf.Min(moveMagnitude, joyStickOutline.rect.width / 2);
    move = direction.normalized * moveMagnitude;

    targetPosition = clickedPosition + move;
    joyStickKnob.position = targetPosition;
    if (Input.GetMouseButtonUp(0))
    {
      HideJoystick();
    }
  }

  public Vector3 GetMoveVector()
  {
    return move;
  }

}
