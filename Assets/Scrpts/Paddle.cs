using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{


    [SerializeField] float velocity = 0.5f;

    [SerializeField] KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] KeyCode downKey = KeyCode.DownArrow;

    void Update()
    {

        //MOVE
        //UP ARROW
        if (Input.GetKey(upKey))
        {
            //Goes Up
            //Delta time -time from the last update
            transform.position += velocity * Vector3.up * Time.deltaTime;



        }
        //DOWN ARROW
        else if (Input.GetKey(downKey))
        {
            //Goes Down
            transform.position += velocity * Vector3.down * Time.deltaTime;


        }

        //VERIFY LIMITS

        //Principal Camera Height
        float cameraHeight = Camera.main.orthographicSize;

        if(transform.position.y >= cameraHeight - 0.5f)
        {
            //You cant edit the component transform for performance issues so you create another variable
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - 0.5f;
            transform.position = positionAux;

        }
        if(transform.position.y <= -cameraHeight + 0.5f)
        {
            //You cant edit the component transform for performance issues so you create another variable
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + 0.5f;
            transform.position = positionAux;

        }


       // Compact way of making the limits (Intervals)
       //0.5f paddle height

       // Vector3 positionAux = transform.position;
       // positionAux.y = Mathf.Clamp(positionAux.y, -cameraHeight + 0.5f, cameraHeight - 0.5f);
       // transform.position = positionAux;


    }
}
