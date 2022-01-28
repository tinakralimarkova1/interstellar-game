using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMan : MonoBehaviour
{
    public Text scoreText;
   // public Text HighScoreText;
    private float score;
    private float hsScore;

    

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 10 * Time.deltaTime;
           scoreText.text = ((int)score).ToString(); 

           if(score > PlayerPrefs.GetFloat("highscore"))
           {
                PlayerPrefs.SetFloat("highscore", score);
           }
          
        }

       // if(score > hsScore)
    //   {
     //       hsScore = score;
//
       //     HighScoreText.text = ((int)hsScore).ToString();
       // }
    } 

    void HS()
    {
       
    }

}
