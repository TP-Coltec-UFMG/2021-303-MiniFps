using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Esta classe é responsável por armazenar/direcionar as demandads do jogadore referente as configurações do jogo.
*/
public class BottomController : MonoBehaviour
{
    // CONJUNTO DE VARIÁVEIS QUE ARMAZENAM AS INFORMAÇÕES ALTERADAS -- PRÉ SAVE
    /* Sensibilidade(mira, movimentação e etc.) */
    [Range(0,1)]   [SerializeField] private float Sensibilidade = 0.5f;
    /* Field Of View(Configuração do angulo de visão da câmera) */
    [Range(1,179)] [SerializeField] private float FOV = 60f;
    /* Sons secundários(Desnecessários para jogar, mas que melhoram a experiência) */
    [SerializeField] private bool SonsSecundarios = true;
    /* Modo Daltonico(Define o jogo com cores altamente discrepantes) */
    [SerializeField] private bool ModoDaltonico = false;
    /* Tamanho da fonte utilizado */
    [SerializeField] private int TamanhoDaFonte = 0;

    //Retorna ao menu principal -- SEM SALVAR AS ALTERAÇÕES
    public void BackToMainManu(){
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    //Retorna ao menu principal -- SALVANDO AS ALTERAÇÕES
    public void BackToMainManu_SAVE(){
        // TO DO -> Implementação do armazenamento das informações
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
