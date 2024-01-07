using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
  void Start()
  {
    ActionTester.myAction += DisplayHealthPopup;
  }

  private void OnDestroy()
  {
    ActionTester.myAction -= DisplayHealthPopup;
  }

  private void DisplayHealthPopup(int health)
  {
    Debug.Log("DisPlaying Health Popup");
  }


}
