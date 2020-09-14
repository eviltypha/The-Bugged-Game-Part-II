using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public static int Scorevalue = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + Scorevalue;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + Scorevalue;
    }
}
