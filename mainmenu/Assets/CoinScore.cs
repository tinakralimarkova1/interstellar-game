using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cont = (int)PlayerPrefs.GetFloat("CoinScore");
        text.text = (cont).ToString();
    }
}
