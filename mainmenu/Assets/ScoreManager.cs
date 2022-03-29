using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
  //  private TextMeshProUGUI text;
    int score;
    int cont;


    // Start is called before the first frame update
    void Start()
    {
        score = (int) PlayerPrefs.GetFloat("CoinScore");
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        
        score += coinValue;

        PlayerPrefs.SetFloat("CoinScore", score);
     //   cont = (int)PlayerPrefs.GetFloat("CoinScore");
     //   text.text = (cont).ToString();
    }

}
