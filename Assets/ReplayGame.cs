using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayGame : MonoBehaviour
{
    public void replay()
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }

        SceneManager.LoadScene("PlayScene");
    }
}
