using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text ScoreText;
  
  
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        print("Sa");
    }
}   

