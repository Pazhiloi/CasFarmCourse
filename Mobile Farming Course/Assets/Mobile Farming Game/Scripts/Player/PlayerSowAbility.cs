using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerAnimator))]
public class PlayerSowAbility : MonoBehaviour
{
  [Header("Elements")]
  private PlayerAnimator playerAnimator;
  [Header("Settings")]
  private CropField currentCropField;


  private void Start() {
    playerAnimator = GetComponent<PlayerAnimator>();

    SeedParticles.onSeedsCollided += SeedsCollidedCallback; 
    CropField.onFullySown += CropFieldFullySownCallback;
  }

  private void OnDestroy() {
    SeedParticles.onSeedsCollided -= SeedsCollidedCallback;
    CropField.onFullySown -= CropFieldFullySownCallback;
  }


  private void SeedsCollidedCallback(Vector3[] seedPositions){
    if (currentCropField == null)
    {
      return;
    }

    currentCropField.SeedsCollidedCallback(seedPositions);
  }

  private void CropFieldFullySownCallback(CropField cropField) {
    if (cropField == currentCropField)
    {
      playerAnimator.StopSowAnimation();
    }
  }

  private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("CropField") && other.GetComponent<CropField>().IsEmpty())
    {
      playerAnimator.PlaySowAnimation();
      currentCropField = other.GetComponent<CropField>();
    }
  }

   private void OnTriggerExit(Collider other) { 
    if (other.CompareTag("CropField"))
    {
      playerAnimator.StopSowAnimation();
      currentCropField = null;
    }
  }
    
}
