using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class Battery_Charges : MonoBehaviour
{
    public static Battery_Charges instance;
    public TMP_Text battery_percent;
    public int now_charge;
    
    private void Awake()
    {
        instance = this;
    }


    public void Start()
    {
      
    }

    public void Update()
    {
       
        if (now_charge < 0)
        {
            
            GameMagangers.instance.gameState = GameStates.gameOver;
            
        }
        if (now_charge < 101)
        {
            if (now_charge < 0)
            {
                battery_percent.text = 0 + "%";
            }
            else
            {
                battery_percent.text = now_charge + "%";
            }
            
        }
        else
        {
            now_charge = 100;
            battery_percent.text = now_charge + "%";
        }

       

        
    }

   
}
