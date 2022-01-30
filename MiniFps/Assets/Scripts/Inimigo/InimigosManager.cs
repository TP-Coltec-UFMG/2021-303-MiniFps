using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigosManager : MonoBehaviour
{
    private GameObject eventSystem;
    private GameControl gameControl;
    private int childs;

    void Start() 
    {
        eventSystem = GameObject.Find("EventSystem");
        gameControl = eventSystem.GetComponent<GameControl>();
    }

    void Update()
    {
        childs = transform.childCount;
        if(childs == 0){
            gameControl.WinSituation();
        }

    }

    private void DeleteEnemies()
    { 
        foreach (Transform child in this.transform) {
            Destroy(child.gameObject);
        }
    }
}
