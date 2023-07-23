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
    public bool dying = true;

    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed > 1.2f && dying == true){
            playerRenderer.enabled = false;
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
        player.transform.localScale = new Vector2(0.01f, 0.01f);
        playerRb.freezeRotation = true;
        player.GetComponent<PlayerGrowth>().reset();
        playerRb.constraints = RigidbodyConstraints2D.None;
        playerRenderer.enabled = true;
        dying = false;
    }
}
