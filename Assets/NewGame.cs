using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public string GameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(GameScene);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
