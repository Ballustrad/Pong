using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Player : MonoBehaviour
{
    public float racketSpeed;
    public string axisName = "Vertical";
    public bool powerUpOn = false;

    private Rigidbody2D rb;
    private Vector2 racketDirection;
    public BallBounce ballBounce;
    public BallMovement ballMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float directionY = Input.GetAxisRaw(axisName);
        racketDirection = new Vector2(0, directionY).normalized;
        
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;

    }
}
