using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameLogicScript logic;
    public BirdAliScript birdAliScript;
    

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogicScript>();
        birdAliScript = GameObject.FindObjectOfType<BirdAliScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3 && birdAliScript.IsBirdAlive )
        {
            logic.increaseScore(1);
        }
        
    }
}
