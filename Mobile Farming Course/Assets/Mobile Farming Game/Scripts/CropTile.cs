using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropTile : MonoBehaviour
{
  public enum State { Empty, Sown, Watered }
  private State state;
  [Header("Settings")]
  [SerializeField] private Transform cropParent;

  private void Start()
  {
    state = State.Empty;
  }

  public void Sow(CropData cropData)
  {
    state = State.Sown;

    Crop crop = Instantiate(cropData.cropPrefab, transform.position, Quaternion.identity, cropParent);
  }

  public bool IsEmpty()
  {
    return state == State.Empty;
  }
}
