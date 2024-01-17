using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public CropType cropType;
    public int amount;

    public InventoryItem(CropType cropType, int amount){
      this.cropType = cropType;
      this.amount = amount;
    }
}
