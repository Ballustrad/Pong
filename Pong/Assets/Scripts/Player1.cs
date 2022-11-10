using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player1 : MonoBehaviour
{
    public float racketSpeed;
    
    
    private Rigidbody2D rb;
    private Vector2 racketDirection;
    public BallBounce ballBounce;
    public BallMovement ballMovement;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
           
            
            if (ballBounce.player1PowerUpOn == true )
            {
                ballMovement.ballSpeed = 35;
                Debug.Log("oui");
                ballBounce.player1PowerUpOn = false;
            }

        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");

        racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;  
    }
}
