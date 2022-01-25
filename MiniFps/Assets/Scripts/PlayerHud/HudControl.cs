using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudControl : MonoBehaviour
{
    [SerializeField] private LifeBar LifeControl;

    // Start is called before the first frame update
    void Start()
    {
        this.LifeControl.AnimacaoInicial(2f);      
    }
    
}
