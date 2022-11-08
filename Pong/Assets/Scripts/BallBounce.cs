using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public BallMovement ballMovement;
  public ScoreManager scoreManager;

    public void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Bounce(Collision2D collision)
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        { 
            Bounce(collision);
            if (collision.gameObject.name == "Player 1")
            {
                GreenBallTouch++;
                if (GreenBallTouch == 1)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg1;
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().color = Color.green;
                }
                else if (GreenBallTouch == 2)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg2;
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().color = Color.green;
                }
                else if (GreenBallTouch == 3)
                {
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg3;
                    GameObject.Find("GreenChargEmpty").GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
            else if (collision.gameObject.name == "Player 2")
            {
                RedBallTouch++;
                if (RedBallTouch == 1)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg1;
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().color = Color.red;
                }
                else if (RedBallTouch == 2)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg2;
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().color = Color.red;
                }
                else if (RedBallTouch == 3)
                {
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().sprite = Charg3;
                    GameObject.Find("RedChargEmpty").GetComponent<SpriteRenderer>().color = Color.red;
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

    }

