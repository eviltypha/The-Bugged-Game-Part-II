using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 10f;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = "Timer: " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
