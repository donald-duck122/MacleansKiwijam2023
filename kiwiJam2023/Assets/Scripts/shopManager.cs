using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopManager : MonoBehaviour
{

    public GameObject player;
    private ItemCollector ItemCollector;
    private player1Movement player1Movement;

     private void Start()
    {
        ItemCollector = player.GetComponent<ItemCollector>();
        player1Movement = player.GetComponent<player1Movement>();
    }


    public void buy1(){
        //money count or somethings
        
        if (ItemCollector.vial > 10){
            ItemCollector.vial -= 10;
            player1Movement.vertical *= 2;
        }
    }
}
