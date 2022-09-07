using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIContro : MonoBehaviour
{
    public static UIContro instance;
    public GameObject mainMenuScens, gamePlayScens, gameOverScens, gameWinScens, levelCompleteScens;
    private void Awake()
    {
        instance = this;
    }
    public void ActiveScreen(bool ISmainMenu, bool ISgamePlay, bool ISgameOver, bool ISgameWin, bool ISlevelComplete)
    {
        mainMenuScens.SetActive(ISmainMenu);
        gamePlayScens.SetActive(ISgamePlay);
        gameOverScens.SetActive(ISgameOver);
        gameWinScens.SetActive(ISgameWin);
        levelCompleteScens.SetActive(ISlevelComplete);
    }
    public void OnPlayBtnClick()
    {
        GameMagangers.instance.gameState = GameStates.gamePlay;
    } public void OnreloadBtnClick()
    {
        SceneManager.LoadSceneAsync("GamePlay");
        GameMagangers.instance.gameState = GameStates.gamePlay;
    } 
    
    public void OnQuitBtnClick()
    {
        Application.Quit();
    }
    
    public void OnhomeBtnClick(string sceneName)
    {
        SceneManager.LoadSceneAsync("GamePlay");
        GameMagangers.instance.gameState = GameStates.mainMenu;
    }
}
