using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI timerText;
    public static float levelScore;
    private float timeInLevel;
    private float score;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        timerText = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = score.ToString();
        levelScore = Mathf.Round(100f - timeInLevel);
        if(levelScore < 0)
        {
            score = 0f;
            timeInLevel = 0f;
            SceneManager.LoadScene(0);
        }
        timerText.text = levelScore.ToString();
        timeInLevel += Time.deltaTime;
    }

    public void NextLevel()
    {
        score += levelScore;
        timeInLevel = 0f;
        SceneManager.LoadScene(0);
    }
}
