using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileFieldState { Empty, Sown, Watered } 
public class CropTile : MonoBehaviour
{
  private TileFieldState state;
  [Header("Settings")]
  [SerializeField] private Transform cropParent;

  private void Start()
  {
    state = TileFieldState.Empty;
  }

  public void Sow(CropData cropData)
  {
    state = TileFieldState.Sown;

    Crop crop = Instantiate(cropData.cropPrefab, transform.position, Quaternion.identity, cropParent);
  }

  public void Water(){
    state = TileFieldState.Watered;
  }

  public bool IsEmpty()
  {
    return state == TileFieldState.Empty;
  }
  public bool IsSown()
  {
    return state == TileFieldState.Sown;
  }
}
