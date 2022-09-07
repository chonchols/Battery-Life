using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class power : MonoBehaviour
{
    public TMP_Text[] power_text;

    public void Start()
    {
        for(int i = 0; i < power_text.Length; i++)
        {
          int powers=  Random.Range(10, 20);
            power_text[i].text = "+" + powers;
        }
    }


}
