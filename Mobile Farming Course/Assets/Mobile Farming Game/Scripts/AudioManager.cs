using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  private void Start()
  {
    ActionTester.myAction += PlayTakeDamageSound;
  }
  private void OnDestroy() {
    ActionTester.myAction -= PlayTakeDamageSound;
  }

  private void PlayTakeDamageSound(int health)
  {
    Debug.Log("Playing taking damage sound");
  }
}
