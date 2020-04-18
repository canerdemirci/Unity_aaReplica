using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public static int PinCount;

    void Start()
    {
        //PinCount = 0;
    }

    void Update()
    {
        scoreText.text = PinCount.ToString();

        if (PinCount >= 10)
            FindObjectOfType<GameManager>().NextLevel();
        else if (PinCount >= 20)
            FindObjectOfType<GameManager>().NextLevel();
        
    }
}
