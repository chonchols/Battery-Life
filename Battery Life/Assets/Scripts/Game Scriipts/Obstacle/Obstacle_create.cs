using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_create : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameMagangers.instance.gameState = GameStates.gameOver;
            PlayerController.instance.animator.SetBool("runing", false);
            Destroy(gameObject);
        }
    }
}
