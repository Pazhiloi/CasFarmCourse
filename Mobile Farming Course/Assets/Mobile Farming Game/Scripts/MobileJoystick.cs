using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileJoystick : MonoBehaviour
{
   [Header("Elements")]
   [SerializeField] private RectTransform joyStickOutline;
   Vector3 clickedPosition;

   public void ClickedOnJoyStickZoneCallback(){
    clickedPosition = Input.mousePosition;
    joyStickOutline.position = clickedPosition;
   }
}
