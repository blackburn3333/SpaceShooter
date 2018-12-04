using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    public Button startGameButton;

	// Use this for initialization
	void Start () {
        startGameButton.onClick.AddListener(StartGame);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartGame()
    {
        Debug.Log("Cicked");
        SceneManager.LoadScene("SampleScene");
    }
}
