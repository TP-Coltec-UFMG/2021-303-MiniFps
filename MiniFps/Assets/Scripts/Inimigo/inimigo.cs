using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    /*private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;*/
    public AudioSource som;

    void Start()
    {
        //moveSpeed = 50f;
        //rb = GetComponent<Rigidbody>();
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        som = GetComponent<AudioSource>();
        NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		GameObject cubo = GameObject.Find ("player");
		Vector3 posicaoDoCubo = cubo.transform.position;
		agent.SetDestination (posicaoDoCubo);
    }

    // Update is called once per frame
    void Update()
    {
        /*dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;*/
    }
    /*void FixedUpdate(){
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }*/
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "player"){
            som.Play();
            Destroy(col.gameObject);
        }
    }
}
