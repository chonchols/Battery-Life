using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackSigma : MonoBehaviour
{
    public static trackSigma instance;
    public GameObject road;
    public int possion_createing;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(road, new Vector3(0f, 0f, possion_createing), Quaternion.identity);
        }
    }
}
