using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopManager : MonoBehaviour
{

    public GameObject player;
    private ItemCollector ItemCollector;
    private player1Movement player1Movement;
    private PlayerGrowth PlayerGrowth;
    private int money;
    private float upgrade = 1;


     private void Start()
    {
        ItemCollector = player.GetComponent<ItemCollector>();
        player1Movement = player.GetComponent<player1Movement>();
        PlayerGrowth = player.GetComponent<PlayerGrowth>();

    }

     private void Update()
    {
        money = (int) (Mathf.Log(upgrade + 1.5f) * 50f);
    }


    public void buy1(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            player1Movement.vertical *= 2;
            upgrade += 1;
        }
    }

    public void buy2(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            player1Movement.horizontal *= 2;
            upgrade += 1;

        }
    }

    public void buy3(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            PlayerGrowth.growthRate /= 2;
            upgrade += 1;
        }
    }
    
    public void buy4(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            ItemCollector.multiplier *= 2;
            upgrade += 1;
        }
    }
}
