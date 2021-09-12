using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Esta classe é responsável por direcionar os botões das configurações.
*/
public class C_ButtonController : MonoBehaviour
{
    // Script que manipula os dados.
    private C_SettingsControl Manager;

    void Start(){
        this.Manager = GameObject.Find("SettingsControl").GetComponent<C_SettingsControl>();
    }

    // Retorna ao menu principal -- SEM SALVAR AS ALTERAÇÕES
    public void BackToMainManu(){
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    // Retorna ao menu principal -- SALVANDO AS ALTERAÇÕES
    public void BackToMainManu_SAVE(){
        this.Manager.SaveData();
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    // Chama o método para resetar as configurações.
    public void ResetConfigs(){
        this.Manager.ResetConfig();
    }
}