using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
  [Header("Elements")]
  [SerializeField] private Animator animator;
  public void ManageAnimations(Vector3 moveVector)
  {

    if (moveVector.magnitude > 0)
    {
      PlayRunAnimation();
    }
    else
    {
      PlayIdleAnimation();
    }
  }

  private void PlayRunAnimation()
  {
    animator.Play("Run");
  }
  private void PlayIdleAnimation()
  {
    animator.Play("Idle");
  }
}
