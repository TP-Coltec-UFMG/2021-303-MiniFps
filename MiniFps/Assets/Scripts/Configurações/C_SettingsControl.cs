using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    [SerializeField] private Toggle[] ModosDaltonico;
    /* Tamanho da fonte utilizado */
    [SerializeField] private Dropdown TamanhoDaFonte;

    /* Caminho para o arquivo que armazena os dados desse objeto */
    private string SavePath = "Assets\\Data\\Configuracoes.json";

    void Start(){
        this.LoadData();
    }

    // Carrega os dados presentes nos arquivos
    public void LoadData(){
        C_JsonFormat Data = JsonUtility.FromJson<C_JsonFormat>(File.ReadAllText(this.SavePath));
        this.Sensibilidade.value = Data.Sensibilidade;
        this.FOV.value = Data.FOV;
        this.SonsSecundarios.isOn = Data.SonsSecundarios;
        this.TamanhoDaFonte.value = Data.TamanhoDaFonte;
        for(int i=0;i<3;i++) this.ModosDaltonico[i].isOn = Data.ModoDaltonico[i];
    }

    // Salva os dados nos arquivos
    public void SaveData(){
        bool[] DaltoArray = new bool[3];
        for(int i=0;i<3;i++) DaltoArray[i] = this.ModosDaltonico[i].isOn;
        C_JsonFormat Data = new C_JsonFormat(this.Sensibilidade.value,this.FOV.value,this.SonsSecundarios.isOn,DaltoArray,this.TamanhoDaFonte.value);
        File.WriteAllText(this.SavePath,JsonUtility.ToJson(Data,true));
    }

    // Restaura as configurações para as previstas inicialmente
    public void ResetConfig(){
        this.Sensibilidade.value = 50;
        this.FOV.value = 60;
        this.SonsSecundarios.isOn = true;
        this.TamanhoDaFonte.value = 0;
        for(int i=0;i<3;i++) this.ModosDaltonico[i].isOn = false;    
    }

    // Desabilita outras opções de daltonismo quando uma é selecionada.
    public void DaltoChange(int index){
        if(!this.ModosDaltonico[index].isOn) return;
        for(int i=0;i<3;i++) if(i != index) this.ModosDaltonico[i].isOn = false;
    }
}