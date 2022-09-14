using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocalAndObstacle_create : MonoBehaviour
{
    public GameObject[] socalmedia;
    public GameObject[] Obstacal;
    public void Start()
    {
        for(int i = 0; i < socalmedia.Length; i++)
        {
            GameObject add = Instantiate(socalmedia[i], new Vector3(-1.255f, 0.16f, 5f*i), Quaternion.identity);
            add.transform.SetParent(gameObject.transform);
        }
    }
}
