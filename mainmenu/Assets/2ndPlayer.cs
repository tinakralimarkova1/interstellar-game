using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 2ndPlayer : MonoBehaviour
{
  public float Speed;
float MovementY;

Rigidbody2D rb;

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
