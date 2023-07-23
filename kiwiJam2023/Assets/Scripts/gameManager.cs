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
    private bool resetting = false;
    public GameObject originalObject;
    private GameObject copiedObject;
    


    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed > 1.2f && dying == true){
            playerRenderer.enabled = false;
            shopGUI.SetActive(true);
            playerAnimator.SetBool("dying", false);

        }

        if(Input.GetKeyDown("r")){
            onDeath();
        }
    }

    public void Start(){
        restart();
        originalObject.SetActive(false);
    }

    public void onDeath(){
        //makes sure the player cannot move before opening the shop
        timePassed = 0;
        playerRb.constraints = RigidbodyConstraints2D.FreezePosition;
        playerAnimator.SetBool("dying", true);
        dying = true;
        DespawnVials();
    }

    public void restart(){
        player.transform.position = new Vector2(100, 6); // 0 -2;
        player.transform.localScale = new Vector2(0.01f, 0.01f);
        player.GetComponent<PlayerGrowth>().reset();
        playerRb.constraints = RigidbodyConstraints2D.None;
        playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
        playerRenderer.enabled = true;
        dying = false;
        RespawnVials();
    }


    public void RespawnVials()
    {
        copiedObject = Instantiate(originalObject, originalObject.transform.position, originalObject.transform.rotation);
        copiedObject.SetActive(true);
        
    }

    public void DespawnVials()
    {
        Destroy(copiedObject);

    }
}
