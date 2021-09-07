using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Esta classe é responsável por direcionar as ações do usuário na tela principal do jogo.
*/
public class ButtonController : MonoBehaviour
{
    // Inicia o jogo
    public void StarGame_SinglePlayer(){

    }

    // Abre as configurações
    public void Settings(){ 
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    // Encerra o jogo
    public void QuitGame(){
        Application.Quit();
    }
}
