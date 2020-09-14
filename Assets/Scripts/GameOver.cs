using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void Display()
    {
        scoreText.text = "" + ScoreDisplay.Scorevalue;
    }*/
    public void Replay()
    {
        SceneManager.LoadScene("Main Game");
        ScoreDisplay.Scorevalue = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
