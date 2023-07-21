using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public GameObject gameManager;

    private void OnCollisionEnter(Collision other) {
        if(other.GameObject.name == "player"){
            gameManager.onDeath();
        }
    }
}
