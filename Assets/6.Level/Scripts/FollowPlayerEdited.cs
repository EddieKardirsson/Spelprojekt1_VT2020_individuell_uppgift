using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerEdited : MonoBehaviour
{
    public float followPower = 1f;
    private Rigidbody rb;
    private Transform player;

    // Use this for initialization
    void Start(){
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No RigidBody found on " + name);
        }
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player == null)
        {
            Debug.Log("Could not find player: " + name);
        }
    }

    // Update is called once per frame
    void Update()  {
        if (rb == null || player == null)
        {
            return;
        }
        Vector3 oldVel = rb.velocity;
        Vector3 toPlayer = player.position - transform.position;
        Vector3 vel = toPlayer.normalized * followPower;
        vel.y = oldVel.y;
        rb.velocity = vel;


        transform.LookAt(player.position);
        //Quaternion to = Quaternion.FromToRotation(rb.transform.forward, toPlayer);

        //rb.transform.rotation = Quaternion.RotateTowards(rb.transform.rotation, to, 5f);
    }
}
