using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropField : MonoBehaviour
{
    

    public void SeedsCollidedCallback(Vector3[] seedPositions){
      Debug.Log("Crop Field received the seed positions");
    }  
}
