using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   private Inventory inventory;
   private string dataPath;

   private void Start() {
    // inventory = new Inventory();
    dataPath = Application.dataPath + "/inventoryData.txt";
    LoadInventory();
    CropTile.onCropHarvested += CropHarvestedCallback;
   }

   private void OnDestroy() {
    CropTile.onCropHarvested -= CropHarvestedCallback;
  }

  private void CropHarvestedCallback (CropType cropType) {
    inventory.CropHarvestedCallback(cropType);
    SaveInventory();
  }

  private void LoadInventory() {
    string data = "";
    if (File.Exists(dataPath))
    {
      data = File.ReadAllText(dataPath);
      inventory = JsonUtility.FromJson<Inventory>(data);
      if (inventory == null)
      {
        inventory = new Inventory();
      }
    }else
    {
      File.Create(dataPath);
      inventory = new Inventory();
    }


  }
  private void SaveInventory() {
    string data = JsonUtility.ToJson(inventory, true);
    File.WriteAllText(dataPath, data);
  }
}
