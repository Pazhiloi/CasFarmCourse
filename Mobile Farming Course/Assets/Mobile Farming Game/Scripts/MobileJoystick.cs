using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileJoystick : MonoBehaviour
{
  [Header("Elements")]
  [SerializeField] private RectTransform joyStickOutline;
  [SerializeField] private RectTransform joyStickKnob;

  [Header("Settings")]
  private bool canControl;
  Vector3 clickedPosition;
  Vector3 currentPosition;
  Vector3 direction;
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
  }

  private void ControlJoystick()
  {
    currentPosition = Input.mousePosition;
    direction = currentPosition - clickedPosition;
    joyStickKnob.position = joyStickOutline.position + direction;
  }

}
