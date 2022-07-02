using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
      

    public float speed ;

    private GameManager gm;

    


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {

        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");
        float yMov = Input.GetAxisRaw("Jump");

        rb.velocity = Vector3.down * speed ;


        //if (Input.GetKey("d") && speed>=0)
        //{
        //    speed -= 7*Time.deltaTime;
        //    gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        //}
        //if(Input.GetKeyUp("d") && speed <8)
        //{
        //    speed += 800*Time.deltaTime;
        //    gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        //}
        if (speed > 9)
        {
            speed = 8;
        }
        if (speed < 1)
        {
            speed = 1.5f;
        }

        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if(finger.phase == TouchPhase.Began)
            {
                speed -= 7 * Time.deltaTime;
                gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (finger.phase == TouchPhase.Stationary)
            {
                speed -= 7 * Time.deltaTime;
                gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }           
            if (finger.phase == TouchPhase.Ended)
            {

                speed += 800 * Time.deltaTime;
                gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            }

        }



        //rb.AddForce(Vector3.down * downSpeed * Time.deltaTime);


        //if (Input.GetKey("d") )
        //{
        // downSpeed -= brake * Time.deltaTime;
        //    rb.AddForce(Vector3.up * brake * Time.deltaTime);
        // }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "UnsafeRing")
        {
            PlayerPrefs.SetInt("scoreData", 0);
            RestartGame();
        }
        if (collision.gameObject.tag == "lastRing")
        {
            nextChapter();
        }
        if(collision.gameObject.tag == "pointdropper")
        {
            gm.GameScore(-50);
        }

        if (collision.gameObject.tag == "rotationChanger")
        {
            
            Rotate.rotationCheck = !Rotate.rotationCheck;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextChapter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
