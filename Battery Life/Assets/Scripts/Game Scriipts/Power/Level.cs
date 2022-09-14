using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{
    public GameObject[] levels;
    
    void Update()
    {
        powerUp();
       
    }

    public void powerUp()
    {
     
        if (Battery_Charges.instance.now_charge < 26)
        {
            powerup(1, true);
            powerdrown(3, true);
        }
        else if (Battery_Charges.instance.now_charge < 51)
        {
            powerup(2, true);
            powerdrown(2, true);  
        }
        else if (Battery_Charges.instance.now_charge < 76)
        {
            powerup(3, true);
            powerdrown(1, true);
        }
        else if (Battery_Charges.instance.now_charge < 101)
        {
            powerup(4, true);
            powerdrown(0, true);
        }
    }

    public void powerup(int level,bool is_leves)
    {        
        if (is_leves)
        {
            for (int i = 0; i < level; i++)
            {
                levels[i].SetActive(true);
               
            }
        }
    }

    public void powerdrown(int level, bool is_leves)
    {
        if (is_leves)
        {
            for (int i = 0; i < level; i++)
            {
                levels[i].SetActive(false);
            }
        }
    }
}
