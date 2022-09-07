using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum GameStates
{
    mainMenu,
    gamePlay,
    gameOver,
    gameWin,
    levelComplete,
    obstacleHit
}
public class GameMagangers : MonoBehaviour
{
    public static GameMagangers instance;
    public GameStates gameState;

    private void Awake()
    {
        instance = this;
    }
    public void Update()
    {
        ManageState();
    }

    public void ManageState()
    {
        if (gameState == GameStates.mainMenu)
        {
            UIContro.instance.ActiveScreen(true, false, false, false, false);
        }
        else if (gameState == GameStates.gamePlay)
        {
            UIContro.instance.ActiveScreen(false, true, false, false, false);
            PlayerController.instance.ManageSlideControl();
        }
        else if (gameState == GameStates.gameOver)
        {
            UIContro.instance.ActiveScreen(false, false, true, false, false);    
        }
        else if (gameState == GameStates.levelComplete)
        {
            UIContro.instance.ActiveScreen(false, false, false, false, true);
        }
        else if (gameState == GameStates.gameWin)
        {
            UIContro.instance.ActiveScreen(false, false, false, true, false);
        }
        else if (gameState == GameStates.obstacleHit)
        {
            UIContro.instance.ActiveScreen(false, false, true, false, false);  
        }
    }

}
