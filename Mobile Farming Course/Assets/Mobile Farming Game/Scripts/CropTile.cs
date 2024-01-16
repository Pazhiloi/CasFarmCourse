using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileFieldState { Empty, Sown, Watered } 
public class CropTile : MonoBehaviour
{
  private TileFieldState state;
  [Header("Elements")]
  [SerializeField] private Transform cropParent;
  [SerializeField] private MeshRenderer tileRenderer;
  private Crop crop;

  private void Start()
  {
    state = TileFieldState.Empty;
  }

  public void Sow(CropData cropData)
  {
    state = TileFieldState.Sown;

     crop = Instantiate(cropData.cropPrefab, transform.position, Quaternion.identity, cropParent);
  }

  public void Water(){
    state = TileFieldState.Watered;

    crop.ScaleUp();

    tileRenderer.gameObject.LeanColor(Color.white * 0.3f, 1f);
  }
 
  public void Harvest(){
    state = TileFieldState.Empty;
    crop.ScaleDown();

    tileRenderer.gameObject.LeanColor(Color.white, 1f);
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
