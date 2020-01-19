using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {


    public float rotationSpeed;
    public AudioSource pickupSound;

    public Transform coinMesh;
    public ParticleSystem pickupEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        coinMesh.localRotation = Quaternion.Euler(0f, Time.time * rotationSpeed, 0f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && coinMesh.gameObject.activeInHierarchy)
        {
            GameLogic.CoinPickup();
            coinMesh.gameObject.SetActive(false);
            pickupSound.Play();
            pickupEffect.Play();
        }
    }
}
