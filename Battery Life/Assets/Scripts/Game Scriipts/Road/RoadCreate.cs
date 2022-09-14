using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RoadCreate : MonoBehaviour
{ 
  //  public GameObject[] road;
    public GameObject road;
    public GameObject[] socalmedia;
    public GameObject[] power; 
    public GameObject[] obstale;
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


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameMagangers.instance.road_createing_value++;
          Instantiate(road, new Vector3(0f, 0f, possion_createing * GameMagangers.instance.road_createing_value), Quaternion.identity);
            creat_socal_obstacle();
        }
    }

    public void creat_socal_obstacle()
    {

        for(int i = 0; i < socalmedia.Length; i++)
        {
            int x = Random.Range(-2, 0);
           
            if (x == -1)
            {
                x =-2;
            }
            Instantiate(socalmedia[i], new Vector3(x, 0.83f, possion_createing * GameMagangers.instance.road_createing_value + 16f * i), Quaternion.identity);
           
        }

        for(int i = 0; i < power.Length; i++)
        {
            int x = Random.Range(-1, 1);
            if (x == 0)
            {
                x = 1;
            }
            Instantiate(power[i], new Vector3(x, 0.76f, possion_createing * GameMagangers.instance.road_createing_value + 21f * i), Quaternion.identity);
        } 
        
        for(int i = 0; i < obstale.Length; i++)
        {
            int x = Random.Range(-1, 1);
            if (x == 0)
            {
                x = 1;
            }
            Instantiate(obstale[i], new Vector3(x, 0f, possion_createing * GameMagangers.instance.road_createing_value + 25f * i), Quaternion.identity);
        }
       
    }

}
