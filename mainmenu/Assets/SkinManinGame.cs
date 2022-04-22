using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManinGame : MonoBehaviour
{
    public int index = 0;
    public GameObject[] shipSkin;
    void Start()
    {
        index = PlayerPrefs.GetInt("SelectedSkin", 0);
        foreach (GameObject skin in shipSkin)
        {
            skin.SetActive(false);
        }

        shipSkin[index].SetActive(true);
    }
}

  

