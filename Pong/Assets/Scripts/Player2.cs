using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float racketSpeed;
   
   
    private Rigidbody2D rb;
    private Vector2 racketDirection;
    public BallBounce ballBounce;
    public BallMovement ballMovement;
    public float speedBonus;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            
            if (ballBounce.player2PowerUpOn == true )
            {
                UpgradeSpeed();
            }

        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");

        racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;
    }

    public void UpgradeSpeed()
    {
        ballMovement.ballSpeed = speedBonus;
        Debug.LogError("Okay1");
        ballBounce.player2PowerUpOn = false;
    }
}
