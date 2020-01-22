using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player : MonoBehaviour
{
    //public void DisableMovement(){
    //    gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
    //    gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
    //}

    //public void EnableMovement(){
    //    gameObject.GetComponent<ThirdPersonCharacter>().enabled = true;
    //    gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
    //}

    private void OnCollisionEnter(Collision other){
        var otherObject = other.gameObject;
        if(otherObject.tag == "Enemy"){
            StartCoroutine(PlayerKilled());
        }
    }

    private IEnumerator PlayerKilled(){
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("Lose");
    }
}
