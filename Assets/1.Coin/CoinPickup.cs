using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public Transform coinMesh;
    public ParticleSystem pickupEffect;
    public AudioSource pickupSound;
    public float rotationSpeed = 180f;

    private readonly float movementHeight = 0.25f;
    private readonly float movementSpeed = 5f;    

    void Update(){
        SetCoinRotation(rotationSpeed);
        SetCoinPosition(movementSpeed, movementHeight);
        AlignLocalPositions();
    }

    private void SetCoinRotation(float rotationSpeed){
        coinMesh.localRotation = Quaternion.Euler(0f, Time.time * rotationSpeed, 0f);
    }

    private void SetCoinPosition(float movementSpeed, float movementHeight){
        coinMesh.transform.localPosition = new Vector3(
            /*coinMesh.position.x*/ 0f,
            coinMesh.position.y + Mathf.Sin(Time.time * movementSpeed),
            /*coinMesh.position.z*/ 0f) * movementHeight;
    }

    private void AlignLocalPositions(){
         pickupSound.transform.localPosition = pickupEffect.transform.localPosition = coinMesh.transform.localPosition;
    }

    //private void OnTriggerEnter(Collider other){
    //    if (other.gameObject.tag == "Player" && coinMesh.gameObject.activeInHierarchy) {
    //        GameLogic.CoinPickup();
    //        coinMesh.gameObject.SetActive(false);
    //        TriggerEvents();
    //    }
    //}

    public void TriggerEvents(){
        pickupEffect.Play();
        pickupSound.Play();
    }
}
