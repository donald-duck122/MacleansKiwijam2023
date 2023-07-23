using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class shopManager : MonoBehaviour
{

    public GameObject player;
    private ItemCollector ItemCollector;
    private player1Movement player1Movement;
    private PlayerGrowth PlayerGrowth;
    private int money;
    private float upgrade = 1;
    [SerializeField] private TextMeshProUGUI vialCost1;
    [SerializeField] private TextMeshProUGUI vialCost2;
    [SerializeField] private TextMeshProUGUI vialCost3;
    [SerializeField] private TextMeshProUGUI vialCost4;
    [SerializeField] private TextMeshProUGUI vialCost5;




     private void Start()
    {
        ItemCollector = player.GetComponent<ItemCollector>();
        player1Movement = player.GetComponent<player1Movement>();
        PlayerGrowth = player.GetComponent<PlayerGrowth>();
        

    }

     private void Update()
    {
        money = (int) (upgrade*upgrade + 20);
        vialCost1.text = "" + money;
        vialCost2.text = "" + money;
        vialCost3.text = "" + money;
        vialCost4.text = "" + money;
        vialCost5.text = "" + money;
    

    }


    public void buy1(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            player1Movement.vertical *= 1.2f;
            upgrade += 1;
        }
    }

    public void buy2(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            player1Movement.horizontal *= 1.2f;
            upgrade += 1;

        }
    }

    public void buy3(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            PlayerGrowth.growthRate /= 1.2f;
            upgrade += 1;
        }
    }
    
    public void buy4(){
        if (ItemCollector.vial >= money){
            ItemCollector.vial -= money;
            ItemCollector.multiplier += 1;
            upgrade += 1;
        }
    }

    public void buy5(){
        ItemCollector.vial -= money;
        upgrade += 1;

    }



}
