using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float totalTime = 1200f;
    private Text timer;
    private GameObject eventSystem;
    private GameControl gameControl;

    private void Start(){
        eventSystem = GameObject.Find("EventSystem");
        gameControl = eventSystem.GetComponent<GameControl>();
        timer = this.GetComponent<Text>();
    }

    private void Update()
    {
       totalTime -= Time.deltaTime;
       UpdateTimer(totalTime);
    }

    public void AddTime(float seconds){
        totalTime += seconds;
         UpdateTimer(totalTime);
    }

    private void UpdateTimer(float totalSeconds)
    {
       int minutes = Mathf.FloorToInt(totalSeconds / 60f);
       int seconds = Mathf.RoundToInt(totalSeconds % 60f);

       string formatedSeconds = seconds.ToString();

       if (seconds == 60)
       {
           seconds = 0;
           minutes += 1;
       }

       timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");

       if(minutes <= 0 && seconds <= 0){
            gameControl.LoseSituation();
       }
    }
}
