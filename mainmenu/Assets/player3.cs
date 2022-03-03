using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3 : MonoBehaviour
{
    public float speed;
    float MovementY;

    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        MovementY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(MovementY * speed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.W))
        {
            MovementY = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MovementY = -1;
        }
    }
}
