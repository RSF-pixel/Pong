using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Search the component rigidbody attached to the ball
        //Random if goes for the right or left 
        //if(Random.value < 0.5)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocity * Vector2.right;
        //}
        //else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocity * Vector2.left;
        //}


        //Get a random vector from a circle
        GetComponent<Rigidbody2D>().velocity = velocity * Random.insideUnitCircle;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
