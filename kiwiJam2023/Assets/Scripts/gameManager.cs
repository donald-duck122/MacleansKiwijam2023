using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer playerRenderer;
    public Rigidbody2D playerRb;
    public GameObject shopGUI;
    public Animator playerAnimator;
    private float timePassed;
    private bool dying;

    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed > 1.2f && dying == true){
            dying = false;
            playerRenderer.enabled = false;
            player.transform.localScale = new Vector2(20.1f, 20.1f);
            shopGUI.SetActive(true);
            playerAnimator.SetBool("dying", false);
        }
    }

    public void Start(){
        restart();
    }

    public void onDeath(){
        //makes sure the player cannot move before opening the shop
        timePassed = 0;
        playerRb.constraints = RigidbodyConstraints2D.FreezePosition;
        playerAnimator.SetBool("dying", true);
        dying = true;
    }

    public void restart(){
        player.transform.position = new Vector2(0,0);
        player.transform.localScale = new Vector2(0.1f, 0.1f);
        player.GetComponent<PlayerGrowth>().reset();
        playerRb.constraints = RigidbodyConstraints2D.None;
        playerRenderer.enabled = true;
    }
}
