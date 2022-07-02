using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossRing : MonoBehaviour
{
    public Transform ball;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y +3.2f <= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }



    }
}
