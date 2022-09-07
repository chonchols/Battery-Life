using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SocialMedia : MonoBehaviour
{
    public TMP_Text[] using_charge;
    void Start()
    {
        for(int i = 0; i < using_charge.LongLength; i++)
        {
            int random = Random.Range(10, 30);
            using_charge[i].text = "-" + random;
        }
         
    }

}
