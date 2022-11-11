using System;
using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BallBounce : MonoBehaviour
{
  public GameObject hitSFX;
    public int RedBallTouch = 0;
    public int GreenBallTouch = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite GreenChargEmpty;
    public Sprite RedChargEmpty;
    public Sprite Charg1;
    public Sprite Charg2;
    public Sprite Charg3;
    public Sprite Charg4;
    public Sprite Charg5;  
    public Sprite Charg6;  
    public Sprite Charg7;
    public Sprite Charg8;
    public Sprite Charg9;
    public Sprite Charg10;
    public Sprite Charg11;
    public Sprite Charg12;
    public Text barFullGreen;
    public Text barFullRed;
    public bool player1PowerUpOn;
    public bool player2PowerUpOn;
    public bool player1Collision;
    public bool player2Collision;
    public ParticleSystem P1;
    public ParticleSystem P2;
    
    
   
   





    public BallMovement ballMovement;
  public ScoreManager scoreManager;

    public void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    
    public void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if(collision.gameObject.name == "Player 1")
        {
            positionX = 1;
        }

        else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        { 
            Bounce(collision);
            if (collision.gameObject.name == "Player 1")
            {
                GetComponent<ParticleSystem>().startColor = Color.green;
                GetComponent<SpriteRenderer>().color = Color.green;
                TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
                myTrailRenderer.material.color = Color.green;


                player2Collision = false;
                player1Collision = true;
                
                GreenBallTouch++;
                
                if (GreenBallTouch == 1)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg1;
                    

                }
                else if (GreenBallTouch == 2)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg2;

                }
                else if (GreenBallTouch == 3)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg3;

                }
                else if (GreenBallTouch == 4)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg4;

                }
                else if (GreenBallTouch == 5)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg5;

                }
                else if (GreenBallTouch == 6)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg6;

                }
                else if (GreenBallTouch == 7)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg7;

                }
                else if (GreenBallTouch == 8)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg8;

                }
                else if (GreenBallTouch == 9)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg9;

                }
                else if (GreenBallTouch == 10)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg10;

                }
                else if (GreenBallTouch == 11)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg11;

                }
                else if (GreenBallTouch == 12)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg12;
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().color = Color.green;
                    barFullGreen.text = "Press E";
                    
                }
                if (player2PowerUpOn == true)
                {
                    player2PowerUpOn = false;
                }

            }
            else if (collision.gameObject.name == "Player 2")

            {
                GetComponent<ParticleSystem>().startColor = Color.red;
                GetComponent<SpriteRenderer>().color = Color.red;
                TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
                myTrailRenderer.material.color = Color.red;


                player1Collision = false;
                player2Collision = true;
                RedBallTouch++;
                if (RedBallTouch == 1)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg1;

                }
                else if (RedBallTouch == 2)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg2;

                }
                else if (RedBallTouch == 3)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg3;

                }
                else if (RedBallTouch == 4)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg4;

                }
                else if (RedBallTouch == 5)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg5;

                }
                else if (RedBallTouch == 6)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg6;

                }
                else if (RedBallTouch == 7)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg7;

                }
                else if (RedBallTouch == 8)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg8;

                }
                else if (RedBallTouch == 9)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg9;

                }
                else if (RedBallTouch == 10)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg10;

                }
                else if (RedBallTouch == 11)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg11;

                }
                else if (RedBallTouch == 12)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg12;
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().color = Color.red;
                    barFullRed.text = "Press M";
                    
                }
               
                
            }
    }

            else if(collision.gameObject.name == "Right Border")
            {
                scoreManager.Player1Goal();
                ballMovement.player1Start = false;
                StartCoroutine(ballMovement.Launch());
            }
            else if(collision.gameObject.name == "Left Border")
            {
                scoreManager.Player2Goal();
                ballMovement.player1Start = true;
                StartCoroutine(ballMovement.Launch());

            }

            Instantiate(hitSFX, transform.position, transform.rotation);
        }
    public void Update()
    {
        if (GreenBallTouch >= 12 )
        {
            if (Input.GetKeyDown(KeyCode.E))
            { 
                GreenBallTouch = 0;
                GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = GreenChargEmpty;
                GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().color = Color.white;
                barFullGreen.text = "";
                player1PowerUpOn = true;
                
            }
            
        }
        if ( RedBallTouch >= 12)
        {
            
            if (Input.GetKeyDown(KeyCode.M))
            {
                RedBallTouch = 0;
                GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = RedChargEmpty;
                GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().color = Color.white;
                barFullRed.text = "";
                player2PowerUpOn = true;
            }
        }
    }
    
}

