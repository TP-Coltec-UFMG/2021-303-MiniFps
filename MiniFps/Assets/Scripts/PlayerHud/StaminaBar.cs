using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    [SerializeField] private Image[] Slots;
    [SerializeField] private Sprite StaminaCheia;
    [SerializeField] private Sprite StaminaVazia;

    private int QuantidadeSlots = 8; // Inicio
    private int AnimacaoSlotsCount;

    public void AnimacaoInicial(float StarDelay){
        Invoke("LoadAnimacaoStamina", StarDelay);      
    }

    public void AddStamina(){
        if(this.QuantidadeSlots >= 4) return;
        this.Slots[this.QuantidadeSlots].sprite = this.StaminaCheia;
        this.QuantidadeSlots++;
    }
    public void RemoveStamina(){
        if(this.QuantidadeSlots <= 0) return;
        this.Slots[this.QuantidadeSlots-1].sprite = this.StaminaVazia;
        this.QuantidadeSlots--;
    }

    // ANIMAÇÃO INICIAL - inicio
        private void LoadAnimacaoStamina(){
            this.AnimacaoSlotsCount = 0;
            PiscaTodasOsSlots(0f);
            PiscaTodasOsSlots(0.8f);
            
            Invoke("AuxStaminaAnime", 1.2f);
        }
        private void AuxStaminaAnime(){
            this.SwitchSlot(this.AnimacaoSlotsCount); 
            this.AnimacaoSlotsCount++;
            if(this.AnimacaoSlotsCount < 8){
                Invoke("AuxStaminaAnime",0.4f); 
            }   
        }
    // ANIMAÇÃO INICIAL - fim

    // ANIMAÇÃO PARA PISCAR TODAS AS VIDAS - inicio
        public void PiscaTodasOsSlots(float StartDelay){
            Invoke("PV_AuxStar",StartDelay);
        }
        private void PV_AuxStar(){
            for(int i=0;i<8;i++) this.SwitchSlot(i);
            Invoke("PV_AuxEnd",0.3f);
        }
        private void PV_AuxEnd(){
            for(int i=0;i<8;i++) this.SwitchSlot(i);   
        }
    // ANIMAÇÃO PARA PISCAR TODAS AS VIDAS - fim


    private void SwitchSlot(int Id){
        if(this.Slots[Id].sprite == this.StaminaCheia){    
            this.Slots[Id].sprite = this.StaminaVazia;
        }else{
            this.Slots[Id].sprite = this.StaminaCheia;
        } 
    }
}
