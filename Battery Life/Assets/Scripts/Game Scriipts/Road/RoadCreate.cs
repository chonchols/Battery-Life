using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RoadCreate : MonoBehaviour
{ 
  // public GameObject[] road;
    public GameObject road;
    public GameObject[] level;
    public int possion_createing;
  
    void Start()
    {
        int roadRandomCreate = Random.Range(0, 10);
      //  InvokeRepeating("creat_socal_obstacle", 1f, 10f);
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


    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameMagangers.instance.road_createing_value++;
          Instantiate(road, new Vector3(0f, 0f, possion_createing * GameMagangers.instance.road_createing_value), Quaternion.identity);
          Instantiate(level[Random.Range(0,5)], new Vector3(0f, 0f, possion_createing * GameMagangers.instance.road_createing_value), Quaternion.identity);
           
        }
    }

}
