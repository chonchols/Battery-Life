using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RoadCreate : MonoBehaviour
{ 
    public GameObject[] road;
    public GameObject allroad;
  //  public GameObject allroadcreate; 
    public GameObject breaks;
    public int numberofroad;
    public float roadindex;
    public float add;
    public int possion_createing;
  
    void Start()
    {
        int roadRandomCreate = Random.Range(0, 10);
     
      /*
        for (int i= 0; i < road.Length; i++)
      {

   
                        if (i < 5)
                        {
                            roadindex = 18f;
                            add = + roadindex*i;
                            allroad = Instantiate(road[i], new Vector3(0, 0, roadindex * i), Quaternion.identity);
                            allroad.transform.SetParent(gameObject.transform);
                            add = allroad.transform.position.z;
                        }
                        else
                        { 
                             roadindex = 9f;

                             float result = add + roadindex - roadindex * 5;
                           
                             allroad = Instantiate(road[i], new Vector3(0, 0, result + roadindex * i), Quaternion.identity);
                             allroad.transform.SetParent(gameObject.transform);
                        }
           
        }
  */
      
    }

  
}
