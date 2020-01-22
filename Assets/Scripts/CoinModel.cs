using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinModel : MonoBehaviour
{
    CoinPickup coinPickup;

    private void Start(){
        coinPickup = GetComponentInParent<CoinPickup>();
    }

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            GameLogic.CoinPickup();
            coinPickup.TriggerEvents();
            gameObject.SetActive(false);            
        }
    }
}
