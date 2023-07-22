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


    public void Start(){
        restart();
    }

    public void onDeath(){
        //makes sure the player cannot move before opening the shop
        playerRb.constraints = RigidbodyConstraints2D.FreezePosition;
        playerAnimator.SetBool("dying", true);
        StartCoroutine(WaitAndContinue(1.2f));
    }

    public void restart(){
        player.transform.position = new Vector2(0,0);
        player.transform.localScale = new Vector2(0.1f, 0.1f);
        player.GetComponent<PlayerGrowth>().reset();
        playerRb.constraints = RigidbodyConstraints2D.None;
        playerRenderer.enabled = true;
    }

    private IEnumerator WaitAndContinue(float seconds)
    {
        yield return new WaitForSeconds(seconds); // Wait for the specified seconds
        playerRenderer.enabled = false;
            player.transform.localScale = new Vector2(20.1f, 20.1f);
        shopGUI.SetActive(true);
        playerAnimator.SetBool("dying", false);
    }
}
