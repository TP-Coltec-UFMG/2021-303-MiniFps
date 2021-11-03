using System;
using UnityEngine;

/*
 *  Esta classe é responsável por formatar os dados referentes as configurações 
 *                  que serão salvos/lidos em um arquivo JSON.
*/
[Serializable]
public class C_Configuracoes
{
    /* Sensibilidade(mira, movimentação e etc.) */
    public float Sensibilidade = 50;
    /* Field Of View(Configuração do angulo de visão da câmera) */
    public float FOV = 60;
    /* Sons secundários(Desnecessários para jogar, mas que melhoram a experiência) */
    public bool SonsSecundarios = true;
    /* Modo Daltonico(Define o jogo com cores altamente discrepantes) */
    public bool ModoDaltonico = false;
    /* Tamanho da fonte utilizado */
    public int TamanhoDaFonte = 0;

    // Construtor vazio.
    public C_Configuracoes(){} 

    // Construtor responsável por inicializar os dados deste objeto.
    public C_Configuracoes(float sensibilidade, float fov, bool sonsSecundarios, bool modoDaltonico, int tamanhoFonte){
        this.Sensibilidade = sensibilidade;
        this.FOV = fov;
        this.SonsSecundarios = sonsSecundarios;
        this.ModoDaltonico = modoDaltonico;
        this.TamanhoDaFonte = tamanhoFonte;
    } 

    // Carrega os dados desse objeto em um arquivo JSON.
    public string ToJson(){
        return JsonUtility.ToJson(this,true);
    }

    // Carrega os dados de uma string JSON nesse objeto.
    public void LoadFromJson(string a_Json){
        JsonUtility.FromJsonOverwrite(a_Json,this);
    }
}