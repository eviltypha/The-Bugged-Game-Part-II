﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public GameObject PauseButton, ResumeButton;
    // Start is called before the first frame update
    void Start()
    {
        PauseButton.gameObject.SetActive(true);
        ResumeButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseResumeButtons(bool ispause)
    {
        if (ispause)
        {
            Time.timeScale = 0;
            PauseButton.gameObject.SetActive(false);
            ResumeButton.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PauseButton.gameObject.SetActive(true);
            ResumeButton.gameObject.SetActive(false);
        }
    }
}
