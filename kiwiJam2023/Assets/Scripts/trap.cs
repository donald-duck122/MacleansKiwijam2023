using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public GameObject gameManager;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == ("Player")){
            gameManager.GetComponent<gameManager>().onDeath();
        }
    }
}
