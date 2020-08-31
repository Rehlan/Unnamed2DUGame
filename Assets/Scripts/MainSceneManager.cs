using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public void StartMenuScene() 
    {
        SceneManager.LoadScene("Menuscene", LoadSceneMode.Single);
    }
    public void StartSagiMenuScene() 
    {
        SceneManager.LoadScene("SagiMenuScene", LoadSceneMode.Single);
    }
    public void StartGameScene() 
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    public void StartOptionsScene() 
    {
        SceneManager.LoadScene("OptionScene", LoadSceneMode.Single);
    }
    public void RunSagiGame() 
    {
        SceneManager.LoadScene("SagiGameScene", LoadSceneMode.Single);
    }
}

