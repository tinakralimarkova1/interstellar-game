using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Newplayersc : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 moveValue;

    public void Move (InputAction.CallbackContext context)
    {

        moveValue = (context.ReadValue<Vector2>() * Time.deltaTime * speed);
    }

   private void Update()
    {
        transform.Translate(moveValue);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
