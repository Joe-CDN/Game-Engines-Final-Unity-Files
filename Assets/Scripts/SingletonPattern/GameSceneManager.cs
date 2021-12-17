using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public Text score;
    public Text clock;

    private int minScore = 0;
    private float startTime = 60;
    private void Awake()
    {
        PersistanceManager.Instance.score = minScore;
        PersistanceManager.Instance.countDown = startTime;
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + PersistanceManager.Instance.score + " ";

        DisplayTime(PersistanceManager.Instance.countDown);
        if(PersistanceManager.Instance.countDown > 0)
        {
            PersistanceManager.Instance.countDown -= Time.deltaTime;
        }
        else
        {
            PersistanceManager.Instance.countDown = 0;
        }

        if(PersistanceManager.Instance.countDown <= 0f)
        {
            SceneManager.LoadScene("End");
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
            timeToDisplay = 0;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        clock.text = "Time: " + minutes + ":" + seconds + " ";
    }
}
