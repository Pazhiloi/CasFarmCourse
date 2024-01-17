using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> items = new List<InventoryItem>();

    public void CropHarvestedCallback(CropType cropType){
      Debug.Log(cropType + " has been harvested");
    }
}
