using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player : MonoBehaviour
{
    public void DisableMovement(){
        gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
    }

    public void EnableMovement(){
        gameObject.GetComponent<ThirdPersonCharacter>().enabled = true;
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
    }
}
