using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public Text score;

    public Text winLose;

    void Update()
    {
        score.text = "Final Score: " + PersistanceManager.Instance.score + " ";

        if(PersistanceManager.Instance.score >= 1000)
        {
            winLose.text = "You got enough cubes!";
        }
        else
        {
            winLose.text = "You didn't get enough cubes! Try again";
        }
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
