using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;
    public float ballSpeed;
    
    public bool player1Start = true;

    public int hitCounter = 0;
    public BallBounce ballBounce ;
    
    

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        rb.velocity = new Vector2(0,0);
        transform.position = new Vector2(0, -1);
        
        GetComponent<SpriteRenderer>().color = Color.white;
        TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
        myTrailRenderer.material.color = Color.blue;
    }

    public IEnumerator Launch()
    {
        RestartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);

        if (player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        rb.velocity = direction * ballSpeed;
    }

    
    
    public void IncreaseHitCounter()
    { if(hitCounter * extraSpeed < maxExtraSpeed)
        { hitCounter++; 
        }
    }
    public void Update()
    {
        

        if (ballBounce.player1PowerUpOn == false && ballBounce.player2PowerUpOn == false)
        {
            ballSpeed = startSpeed + hitCounter * extraSpeed;
        }


    }
    


}
