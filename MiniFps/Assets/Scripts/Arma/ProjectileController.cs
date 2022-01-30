using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] int damage = 1; 

    void Start()
    {
        Destroy(gameObject, 5);
    }

    public void OnTriggerEnter(Collider collider){
        InimigoAI enemy = collider.GetComponent<InimigoAI>();
        if( enemy != null ){
            enemy.TakeDamage(this.damage);
            Destroy(gameObject);
        }
    }
}