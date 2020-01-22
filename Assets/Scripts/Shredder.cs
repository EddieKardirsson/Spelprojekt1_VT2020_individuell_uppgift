using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag != "Player")
            Destroy(other.gameObject);
    }
}
