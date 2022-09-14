using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "social"|| other.gameObject.tag == "power"|| other.gameObject.tag == "obstacle")
        {
            Destroy(other.gameObject);
        }
        
    }
}
