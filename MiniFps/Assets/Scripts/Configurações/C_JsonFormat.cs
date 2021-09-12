using System;

/*
 *  Esta classe é responsável por formatar os dados referentes as configurações 
 *                  que serão salvos/lidos em um arquivo JSON.
*/
[Serializable]
public class C_JsonFormat
{
    /* Sensibilidade(mira, movimentação e etc.) */
    public float Sensibilidade;
    /* Field Of View(Configuração do angulo de visão da câmera) */
    public float FOV;
    /* Sons secundários(Desnecessários para jogar, mas que melhoram a experiência) */
    public bool SonsSecundarios;
    /* Modo Daltonico(Define o jogo com cores altamente discrepantes) */
    public bool[] ModoDaltonico;
    /* Tamanho da fonte utilizado */
    public int TamanhoDaFonte;

    // Construtor responsável por inicializar os dados deste objeto.
    public C_JsonFormat(float sensibilidade, float fov, bool sonsSecundarios, bool[] modoDaltonico, int tamanhoFonte){
        this.Sensibilidade = sensibilidade;
        this.FOV = fov;
        this.SonsSecundarios = sonsSecundarios;
        this.ModoDaltonico = modoDaltonico;
        this.TamanhoDaFonte = tamanhoFonte;
    } 
}