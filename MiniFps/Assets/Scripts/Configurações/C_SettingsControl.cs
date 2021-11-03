using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
 * Responsável por gerenciar as configurações.
*/
public class C_SettingsControl : MonoBehaviour
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

    /* Objeto com os dados das configurações */
    private C_Configuracoes Data;

    /* Caminho para o arquivo que armazena os dados desse objeto */
    private string SavePath = "\\Saves\\Configuracoes.json";
    private string DirectoryPath = "\\Saves";

    void Start(){
        this.SavePath       = Application.persistentDataPath + this.SavePath;
        this.DirectoryPath  = Application.persistentDataPath + this.DirectoryPath;

        this.LoadData();
    }

    // Carrega os dados presentes nos arquivos
    public void LoadData(){
        this.Data = new C_Configuracoes();
        try{
            this.Data.LoadFromJson(File.ReadAllText(this.SavePath));
        }catch{
            Debug.Log("error");
            this.SaveData();
        }

        this.Sensibilidade.value    = this.Data.Sensibilidade;
        this.FOV.value              = this.Data.FOV;
        this.SonsSecundarios.isOn   = this.Data.SonsSecundarios;
        this.TamanhoDaFonte.value   = this.Data.TamanhoDaFonte;
        this.ModoDaltonico.isOn     = this.Data.ModoDaltonico;
    }

    // Salva os dados nos arquivos
    public void SaveData(){
        if(!Directory.Exists(this.DirectoryPath)) Directory.CreateDirectory(this.DirectoryPath);
        
        this.Data.Sensibilidade     = this.Sensibilidade.value;
        this.Data.FOV               = this.FOV.value;
        this.Data.SonsSecundarios   = this.SonsSecundarios.isOn;
        this.Data.TamanhoDaFonte    = this.TamanhoDaFonte.value;
        this.Data.ModoDaltonico     = this.ModoDaltonico.isOn;

        File.WriteAllText(this.SavePath,this.Data.ToJson());
    }

    // Restaura as configurações para as previstas inicialmente
    public void ResetConfig(){
        this.Sensibilidade.value = 50;
        this.FOV.value = 60;
        this.SonsSecundarios.isOn = true;
        this.TamanhoDaFonte.value = 0;
        this.ModoDaltonico.isOn = false;    
    }
}