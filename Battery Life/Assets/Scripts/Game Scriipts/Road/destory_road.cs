using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory_road : MonoBehaviour
{
    public GameObject rrr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(rrr,2f);
        }
    }
}
