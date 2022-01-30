using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponsManager : MonoBehaviour {
    [SerializeField] private ShootingController[] weapons;

    private int currentWeapon;

    void Start(){
        currentWeapon = 0;
        weapons[currentWeapon].gameObject.SetActive(true);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            changeWeapon(0);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            changeWeapon(1);
        }
    }

    void changeWeapon(int new_weaponIndex){
        weapons[currentWeapon].gameObject.SetActive(false);
        weapons[new_weaponIndex].gameObject.SetActive(true);
        currentWeapon = new_weaponIndex;
    }

    public ShootingController GetCurrentWeapon(){
        return weapons[currentWeapon];
    }
}