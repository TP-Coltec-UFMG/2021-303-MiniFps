using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InimigoAI : MonoBehaviour
{   
    public enum EnemyAction { neutral, trap, bonus }
    public EnemyAction act;

    [SerializeField] private int life = 10; 
    private GameObject timerObject;
    private Timer timer;

    void Start(){
        GameObject hud = GameObject.Find("Canvas_PlayerHud");
        Transform[] ts = hud.transform.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in ts) if (t.gameObject.name == "Timer") timerObject = t.gameObject;
        timer = timerObject.GetComponent<Timer>();
    }

    public void TakeDamage(int damage){
        life = life - damage;

        if(life <= 0) { 
            StartCoroutine(Die());
            Debug.Log(act);
            if(act == EnemyAction.bonus ){
                timer.AddTime(30f);
            }
            else if (act == EnemyAction.trap ){
                timer.AddTime(- 60f);
            }
        }

        StartCoroutine(ChangeColor());
    }

    private IEnumerator Die(){
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }

    private IEnumerator ChangeColor(){
        var r = this.GetComponent<Renderer>();
        r.material.SetColor("_Color", Color.red);
        yield return new WaitForSeconds(.5f);
        r.material.SetColor("_Color", Color.white);
    }

    public void SetAction(EnemyAction action){
        this.act = action;
    }
}
