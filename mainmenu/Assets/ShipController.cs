using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    Vector2 movement;
    public float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMoveUp()
    {

        transform.Translate(-transform.up);
        
    }
    private void OnMoveDown()
    {

        transform.Translate(transform.up);

    }
}
