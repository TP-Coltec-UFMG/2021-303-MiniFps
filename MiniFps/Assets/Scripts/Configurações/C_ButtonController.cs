using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Esta classe é responsável por armazenar/direcionar as demandads do jogadore referente as configurações do jogo.
*/
public class C_ButtonController : MonoBehaviour
{
    /* Sensibilidade(mira, movimentação e etc.) */
    [SerializeField] private Slider Sensibilidade;
    /* Field Of View(Configuração do angulo de visão da câmera) */
    [SerializeField] private Slider FOV;
    /* Sons secundários(Desnecessários para jogar, mas que melhoram a experiência) */
    [SerializeField] private Toggle SonsSecundarios;
    /* Modo Daltonico(Define o jogo com cores altamente discrepantes) */
    [SerializeField] private Toggle ModoDaltonico;
    /* Tamanho da fonte utilizado */
    [SerializeField] private Dropdown TamanhoDaFonte;

    /* Caminho para o arquivo que armazena os dados desse objeto */
    private string SavePath = "Assets/Data/Configuracoes.json";

    void Start(){
        this.LoadData();
    }

    // Retorna ao menu principal -- SEM SALVAR AS ALTERAÇÕES
    public void BackToMainManu(){
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    // Retorna ao menu principal -- SALVANDO AS ALTERAÇÕES
    public void BackToMainManu_SAVE(){
        this.SaveData();
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    // Carrega os dados presentes nos arquivos
    private void LoadData(){
        C_JsonFormat Data = JsonUtility.FromJson<C_JsonFormat>(File.ReadAllText(this.SavePath));
        this.Sensibilidade.value = Data.Sensibilidade;
        this.FOV.value = Data.FOV;
        this.SonsSecundarios.isOn = Data.SonsSecundarios;
        this.ModoDaltonico.isOn = Data.ModoDaltonico;
        this.TamanhoDaFonte.value = Data.TamanhoDaFonte; 
    }

    // Salva os dados nos arquivos
    private void SaveData(){
        C_JsonFormat Data = new C_JsonFormat(this.Sensibilidade.value,this.FOV.value,this.SonsSecundarios.isOn,this.ModoDaltonico.isOn,this.TamanhoDaFonte.value);
        File.WriteAllText(this.SavePath,JsonUtility.ToJson(Data,true));
    }

    // Restaura as configurações para as previstas inicialmente
    public void ResetConfig(){
        this.Sensibilidade.value = 50;
        this.FOV.value = 60;
        this.SonsSecundarios.isOn = true;
        this.ModoDaltonico.isOn = false;
        this.TamanhoDaFonte.value = 0;    
    }
}