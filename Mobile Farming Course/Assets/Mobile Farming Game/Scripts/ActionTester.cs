using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTester : MonoBehaviour
{
  public Action<int> myAction;


  private void Start()
  {
    myAction?.Invoke(7);
  }


  private void IncrementInt(int myInt)
  {
    myInt++;
    Debug.Log(myInt);
  }
  private void DoubleInt(int myInt)
  {
    myInt *= 2;
    Debug.Log(myInt);
  }
}
