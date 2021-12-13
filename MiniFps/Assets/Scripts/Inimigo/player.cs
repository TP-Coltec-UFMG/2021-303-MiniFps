using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;

    void Start()
    {
        moveSpeed = 50f;
        rb = GetComponent<Rigidbody>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        NavMeshAgent agent = GetComponent<NavMeshAgent> ();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;
    }
    void FixedUpdate(){
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
