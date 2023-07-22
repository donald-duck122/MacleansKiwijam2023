using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{

    private int vial = 0;
    [SerializeField] private TextMeshProUGUI vialText;
    
private void OnTriggerEnter2D(Collider2D collision){

    if(collision.gameObject.CompareTag("Vial")){
        Destroy(collision.gameObject);
        vial++;
        Debug.Log("Vials" + vial);

        vialText.text = "Vials: " + vial;

    }

}


}
