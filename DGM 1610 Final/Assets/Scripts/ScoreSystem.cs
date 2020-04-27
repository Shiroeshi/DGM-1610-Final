using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    public static int score;
    public float gameScore;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void AddPoints(int pointsToAdd) //setting it as public makes it so that other codes can interact with this script.
    {
        score += pointsToAdd;
    }

    private void GameFinish()
    {
        if (gameScore == 30)
        {
            Application.Quit();
        }
    }
}
