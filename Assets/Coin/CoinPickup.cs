using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public Transform coinMesh;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player" && coinMesh.gameObject.activeInHierarchy){
            GameLogic.CoinPickup();
            coinMesh.gameObject.SetActive(false);
        }
    }


}
