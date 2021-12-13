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
    [SerializeField] private C_SettingsControl Manager;

    void Start(){
        //this.Main = GameObject.Find("ButtonController").GetComponent<MP_ButtonController>();
    }

    // Fecha as configurações -- SEM SALVAR AS ALTERAÇÕES
    public void CloseConfig(){
        SceneManager.UnloadSceneAsync("Configuracoes");
    }

    // Fecha as configurações -- SALVANDO AS ALTERAÇÕES
    public void CloseConfig_SAVE(){
        this.Manager.SaveData();
        SceneManager.UnloadSceneAsync("Configuracoes");
    }

    // Chama o método para resetar as configurações.
    public void ResetConfigs(){
        this.Manager.ResetConfig();
    }
}