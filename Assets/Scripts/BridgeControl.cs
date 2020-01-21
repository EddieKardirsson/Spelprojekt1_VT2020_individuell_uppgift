using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    Animator animator;
    
    void Start(){
        animator = GetComponent<Animator>();
    }

    public void SetBridgeDown(string name){
        animator.SetTrigger(name);
    }    
}
