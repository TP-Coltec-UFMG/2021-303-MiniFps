using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Image[] Vidas;
    [SerializeField] private Sprite VidaCheia;
    [SerializeField] private Sprite VidaVazia;

    private int QuantidadeVidas = 4; // Inicio
    private int AnimacaoVidaCount;

    public void AnimacaoInicial(float StarDelay){
        Invoke("LoadAnimacaoVida", StarDelay);      
    }

    public void AddVida(){
        if(this.QuantidadeVidas >= 4) return;
        this.Vidas[this.QuantidadeVidas].sprite = this.VidaCheia;
        this.QuantidadeVidas++;
    }
    public void RemoveVida(){
        if(this.QuantidadeVidas <= 0) return;
        this.Vidas[this.QuantidadeVidas-1].sprite = this.VidaVazia;
        this.QuantidadeVidas--;
    }

    // ANIMAÇÃO INICIAL - inicio
        private void LoadAnimacaoVida(){
            this.AnimacaoVidaCount = 0;
            PiscaTodasAsVidas(0f);
            PiscaTodasAsVidas(0.8f);
            
            Invoke("AuxLifeAnime", 1.2f);
        }
        private void AuxLifeAnime(){
            this.SwitchVida(this.AnimacaoVidaCount); 
            this.AnimacaoVidaCount++;
            if(this.AnimacaoVidaCount < 4){
                Invoke("AuxLifeAnime",0.4f); 
            }   
        }
    // ANIMAÇÃO INICIAL - fim

    // ANIMAÇÃO PARA PISCAR TODAS AS VIDAS - inicio
        public void PiscaTodasAsVidas(float StartDelay){
            Invoke("PV_AuxStar",StartDelay);
        }
        private void PV_AuxStar(){
            for(int i=0;i<4;i++) this.SwitchVida(i);
            Invoke("PV_AuxEnd",0.3f);
        }
        private void PV_AuxEnd(){
            for(int i=0;i<4;i++) this.SwitchVida(i);   
        }
    // ANIMAÇÃO PARA PISCAR TODAS AS VIDAS - fim


    private void SwitchVida(int Id){
        if(this.Vidas[Id].sprite == this.VidaCheia){    
            this.Vidas[Id].sprite = this.VidaVazia;
        }else{
            this.Vidas[Id].sprite = this.VidaCheia;
        } 
    }
        
}
