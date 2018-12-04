using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

   

    public float sceneChaneSpeed = 2f;
    
    public void SceneType(string type)
    {
        if(type == "GameOver")
        {
            Invoke("GameOverScene", sceneChaneSpeed);
        }else if(type == "Star")
        {
            StartGame();
        }
    }

    void GameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    void StartGame()
    {
        SceneManager.LoadScene("Start");
    }
}
