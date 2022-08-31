using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Vector3))]
//This script adjusts the player's position according to a chosen vector3data file
public class playerPos : MonoBehaviour
{
  //create public containers for player, and desired position
  public Vector3Data startPos;
  public GameObject player;
  private void Start()
  {
    
    UpdatePos();
  }

  public void UpdatePos()
  {
    //at start, move the player to the chosen vector3
    player.transform.position = (startPos.value);
   
  }
}
