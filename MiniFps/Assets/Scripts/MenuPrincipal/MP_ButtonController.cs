using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Esta classe é responsável por direcionar as ações do usuário na tela principal do jogo.
*/
public class MP_ButtonController : MonoBehaviour
{
    // Inicia o jogo
    public void StarGame_SinglePlayer(){
        SceneManager.LoadScene("Mapa Base", LoadSceneMode.Single);
    }

    // Abre as configurações
    public void Settings(){ 
        SceneManager.LoadScene("Configuracoes", LoadSceneMode.Additive);
    }

    // Encerra o jogo
    public void QuitGame(){
        Application.Quit();
    }
}
