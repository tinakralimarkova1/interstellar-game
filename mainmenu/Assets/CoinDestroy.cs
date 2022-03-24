using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinDestroy : MonoBehaviour
{
    public Text coinV;
    private float CoinC = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            CoinC += 1;
            coinV.text = ((int)CoinC).ToString();
            Destroy(other.gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}

