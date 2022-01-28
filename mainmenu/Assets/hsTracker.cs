using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hsTracker : MonoBehaviour
{

    public Text HStext;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         HStext.text =((int) PlayerPrefs.GetFloat("highscore")).ToString();
    }
}
