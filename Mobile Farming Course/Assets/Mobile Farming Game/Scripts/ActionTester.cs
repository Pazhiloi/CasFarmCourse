using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTester : MonoBehaviour
{
  public static Action<int> myAction;
  private void Start()
  {
    myAction?.Invoke(7);
  }
}
