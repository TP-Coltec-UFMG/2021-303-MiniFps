using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MB_ButtonController : MonoBehaviour
{
    public void BackToMainMenu(){
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
