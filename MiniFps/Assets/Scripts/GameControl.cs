using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{   
    [SerializeField] private GameObject WinObj;
    [SerializeField] private GameObject LoseObj;
    [SerializeField] private GameObject ButtonObj;

    private void aux(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        ButtonObj.SetActive(true);
    }

    public void WinSituation(){
        this.aux();
        WinObj.SetActive(true);
                
    }

    public void LoseSituation(){
        this.aux();
        LoseObj.SetActive(true);    
    }
}
