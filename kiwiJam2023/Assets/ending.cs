using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator playerAnimator;
    public Animator whiteoutAnimator;
    public GameObject player;
    public float shrinkScale;

    private float timePassed;
    private float initialScale;
    private bool playerEntered = false;

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("should be opening");
        if(other.gameObject.name == ("Player")){
            timePassed = 0;
            initialScale = player.transform.localScale.x;
            playerEntered = true;
            doorAnimator.SetBool("doorOpening", true);
            
        }
    }

    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed > 2 && playerEntered == true && player.transform.localScale.x > 0.01){
            playerAnimator.SetBool("moving", true);
            playerAnimator.SetBool("ending", true);
            initialScale -= shrinkScale;
            player.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        }
        if(playerEntered == true && player.transform.localScale.x <= 0.1){
            whiteoutAnimator.SetBool("whiteout", true);
        }

        if(timePassed>10 && playerEntered == true){
            SceneManager.LoadScene(0);
        }
    }
}
