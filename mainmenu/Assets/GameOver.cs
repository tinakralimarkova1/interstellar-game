using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
   // public Text HStext;

   private void Start()
   {
   //scoreText.text = ((int)score).ToString();
         // HStext.text =((int) PlayerPrefs.GetFloat("highscore")).ToString();
   }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }

        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMain() => SceneManager.LoadScene(0);
}
