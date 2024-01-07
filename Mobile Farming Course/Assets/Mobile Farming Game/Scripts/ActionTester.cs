using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTester : MonoBehaviour
{
    public Action myAction;


    private void Start() {
      // myAction = DebugANumber;
      // myAction += DebugAString;
      myAction?.Invoke();
    }

    private void DebugANumber(){
      Debug.Log("5");
    }
    private void DebugAString(){
      Debug.Log("Hello World");
    }
}
