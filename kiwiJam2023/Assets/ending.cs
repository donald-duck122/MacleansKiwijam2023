using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator playerAnimator;
    public GameObject player;

    private float timePassed;
    private bool playerEntered = false;

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == ("Player")){
            timePassed = 0;
            playerEntered = true;
            doorAnimator.SetBool("opening", true);
            
        }
    }

    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed > 2 && playerEntered == true){
            playerAnimator.SetBool("moving", true);
            //player.transform.localScale = new Vector3
        }
    }
}
