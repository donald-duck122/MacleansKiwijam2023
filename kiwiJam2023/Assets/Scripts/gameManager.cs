using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D playerRb;
    public GameObject shopGUI;

    public void onDeath(){
        //makes sure the player cannot move before opening the shop
        playerRb.constraints = RigidbodyConstraints2D.FreezePosition;
        shopGUI.SetActive(true);
    }

    public void restart(){
        Debug.Log("what");
        player.transform.position = new Vector2(0,0);
        Debug.Log("restarting");
    }
}
