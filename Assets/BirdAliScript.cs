using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAliScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public GameLogicScript logic;
    public bool IsBirdAlive = true ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsBirdAlive )
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (gameObject.transform.position.y > 8 || gameObject.transform.position.y < -9 )
        {
            IsBirdAlive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        IsBirdAlive = false;
        logic.gameOver();
    }
}
