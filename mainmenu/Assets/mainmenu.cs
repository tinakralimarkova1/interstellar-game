using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{

    public void PlayGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    public void MainSettings() => SceneManager.LoadScene(2);

    public void QuitGame() => Application.Quit();

    public void BackToMain () => SceneManager.LoadScene(0);

    public void Highscore() => SceneManager.LoadScene(7);

    

    public void MultiStart() => SceneManager.LoadScene(5);

    public void CharecterMenu() => SceneManager.LoadScene(6);
}

