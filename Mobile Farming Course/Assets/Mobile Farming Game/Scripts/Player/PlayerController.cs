using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
  [Header("Elements")]
  [SerializeField] private MobileJoystick joystick;
  [SerializeField] private PlayerAnimator playerAnimator;
  private CharacterController characterController;
  [Header("Settings")]
  [SerializeField] private float moveSpeed;

  Vector3 moveVector;
  private void Start()
  {
    characterController = GetComponent<CharacterController>();
  }

  private void Update()
  {
    ManageMovement();
  }

  private void ManageMovement()
  {
    moveVector = joystick.GetMoveVector() * moveSpeed * Time.deltaTime / Screen.width;

    moveVector.z = moveVector.y;
    moveVector.y = 0;


    characterController.Move(moveVector);

    playerAnimator.ManageAnimations(moveVector);
  }
}
