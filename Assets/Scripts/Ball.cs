using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public Rigidbody rb;

    public float jumpForce;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SafeRing") {
            rb.AddForce(Vector3.up * jumpForce);
        }
        if (collision.gameObject.tag == "stickyRing")
        {
            rb.AddForce(Vector3.up * jumpForce*0.5f);
        }

        if (collision.gameObject.tag == "UnsafeRing")
        {
            RestartGame();
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
