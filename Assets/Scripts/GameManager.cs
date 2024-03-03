using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore = 0;
    static GameObject UICanvas;

    static public void IncreaseScore(int targetScore)
    {
        playerScore += targetScore;
        DisplayScore();
    }

    static void DisplayScore()
    {
        if(UICanvas != null)
        {
            UICanvas.GetComponentInChildren<TextMeshProUGUI>().text = playerScore.ToString();
        }
    }

    void Start()
    {
        UICanvas = GameObject.Find("UICanvas");
    }

}
