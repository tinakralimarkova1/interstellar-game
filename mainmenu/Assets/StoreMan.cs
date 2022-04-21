using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class StoreMan : MonoBehaviour
{
    public int index = 0;
    public GameObject[] shipSkin;
    void Start()
    {
        index = PlayerPrefs.GetInt("SelectedSkin", 0);
        foreach(GameObject skin in shipSkin)
        {
            skin.SetActive(false);
        }

        shipSkin[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        shipSkin[index].SetActive(false);
        index++;
        if(index == shipSkin.Length)
        {
            index = 0;
        }
        shipSkin[index].SetActive(true);
        PlayerPrefs.SetInt("SelectedSkin", index);
    }
    public void Back()
    {
        shipSkin[index].SetActive(false);
        index--;
        if (index == -1)
        {
            index = shipSkin.Length-1 ;
        }
        shipSkin[index].SetActive(true);
        PlayerPrefs.SetInt("SelectedSkin", index);
    }
    public void PlayGame()
    {
       
        SceneManager.LoadScene(7);
    }
}
