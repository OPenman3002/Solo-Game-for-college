using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public string gameOverScene = "name";
    public string prefsKey = "time";
    public int startScore = 100;
    public float scoreDecreaseFrequency = 1;
    public int scoreDecreaseAmount = 1;
   
    private int currentScore = 0;
    private float lastScoreDecrease = 0;

    void Start()
    {
        currentScore = startScore;
        Text display = GetComponent<Text>();
        display.text = "Time: " + currentScore;

        PlayerPrefs.SetInt(prefsKey, currentScore);
    }


    // Update is called once per frame
    void Update()
    {

        // If it's time to decrease the score again...
        if (Time.time >= lastScoreDecrease + scoreDecreaseFrequency)
        {
            currentScore = currentScore - scoreDecreaseAmount;
            lastScoreDecrease = Time.time;
            // update visuals
            Text display = GetComponent<Text>();
            display.text = "Time: " + currentScore;

            PlayerPrefs.SetInt(prefsKey, currentScore);

            if (currentScore <= 0)
            {              
                SceneManager.LoadScene(2);
            }
        }
    }
}
