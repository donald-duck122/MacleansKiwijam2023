using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{

    public int vial = 0;
    public int multiplier = 1;
    [SerializeField] private TextMeshProUGUI vialText;
    [SerializeField] private TextMeshProUGUI ShopText;
    
    
private void OnTriggerEnter2D(Collider2D collision){

    if(collision.gameObject.CompareTag("Vial")){
        Destroy(collision.gameObject);
        vial = vial + 1 * multiplier;
        Debug.Log("Vials" + vial);

        vialText.text = "Vials: " + vial;
        

    }

}

void Update(){
    vialText.text = "Vials: " + vial;
    ShopText.text = "" + vial;
}


}
