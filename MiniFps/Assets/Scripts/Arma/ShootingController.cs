using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public float moveForce;
    public GameObject bullet;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp;
    Animator m_animator;
    AudioSource audio_data;
    Camera m_camera; 

    void Start()
    {
        m_animator = GetComponent<Animator>();
        audio_data = GetComponent<AudioSource>();
        m_camera = GetComponentInParent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            if (Time.time > m_shootRateTimeStamp)
            {
                m_animator.SetTrigger("Shoot");
                audio_data.Play(0);

                GameObject go = (GameObject)Instantiate(
                bullet, gun.position, gun.rotation);

                go.GetComponent<Rigidbody>().AddForce(m_camera.transform.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
            }

        }

    }

}