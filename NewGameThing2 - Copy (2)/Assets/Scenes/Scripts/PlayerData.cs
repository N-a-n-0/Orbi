using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
   public GameObject currentSoundBlcoks;
   
   public float[] position;


   public PlayerData (SceneData scene)
   {
      position = new float [3];
      position[0] = scene.transform.position.x;
      position[1] = scene.transform.position.y;
      position[2] = scene.transform.position.z;
   }
}
