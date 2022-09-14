using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collitonsocal : MonoBehaviour
{
    public static Collitonsocal instance;
    public TMP_Text text;
    public int percent;
    public void Update()
    {
        percent = int.Parse(text.text);
    }

    private void Awake()
    {
        instance = this;
    }


    public void Start()
    {
        text.text ="-" + Random.Range(10, 30);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
          int less= Battery_Charges.instance.now_charge + percent;
            Battery_Charges.instance.now_charge = less;
            Destroy(gameObject); 
        }
    }
}
