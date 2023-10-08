using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -24 ; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position =  transform.position + (Vector3.left * moveSpeed) * Time.deltaTime ;

       if (transform.position.x < deadZone)
       {
           Debug.Log("Pipe Canceled");
           Destroy(gameObject);
       }
    }
}
