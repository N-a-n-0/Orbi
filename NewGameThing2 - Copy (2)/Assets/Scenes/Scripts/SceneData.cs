using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour
{
    
      public int level = 3;
      //public int level = 40;
     
      public void SavePLayer()
      {
       SaveSystem.SavePlayer(this);
      }
     
      public void SavePlayer()
     {
       PlayerData data = SaveSystem.LoadPlayer();
     
      //level = data.level;
    //  health = data.health;
     
      Vector3 position;
      position.x = data.position[0];
     position.y = data.position[1];
     position.z = data.position[2];
      transform.position = position;
      


      }
     
}
