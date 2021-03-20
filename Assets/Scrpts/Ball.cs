using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float velocity = 5f;
    bool throwBall = false;
    // Start is called before the first frame update
    void Start()
    {
        /*Search the component rigidbody attached to the ball
        Random if goes for the right or left 
        if(Random.value < 0.5)
        {
            GetComponent<Rigidbody2D>().velocity = velocity * Vector2.right;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = velocity * Vector2.left;
        }


        Get a random vector from a circle

        GetComponent<Rigidbody2D>().velocity = velocity * Random.insideUnitCircle;

        */
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time gives me the time since the game start so better for this case
        float timeSinceStart = Time.time;
        // Debug.Log(timeSinceStart);

        //If since the begining of the game passed 2 seconds and the ball hasnt been put in motion yet  
        if (timeSinceStart > 2)
        {
            if (throwBall == false)
            {
                lancarBola();
            }
        }
    }

    //After the game puts the ball on motion he changes the throwBall to true to prevent more updates to the ball
    void lancarBola()
    {
        throwBall = true;
        GetComponent<Rigidbody2D>().velocity = velocity * Random.insideUnitCircle;
    }
}
