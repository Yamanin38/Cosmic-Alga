using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgaController : MonoBehaviour
{
    public Vector2 position;
    private float speed = 0.014f;

    public void GoX(){
            if(position.x < 9.25)
                position.x += speed;
    }

        public void BackX(){
            if(position.x > -9.25)
                position.x -= speed;
    }

        public void GoY(){
            if(position.y < 4.7)
                position.y += speed;
    }

        public void BackY(){
            if(position.y > -4.6)
                position.y -= speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        if (Input.GetKey("left") && Input.GetKey("down"))
        {
                BackX();
                BackY();
        }
        else if (Input.GetKey("left") && Input.GetKey("up"))
        {
            BackX();
            GoY();
        }
        else if (Input.GetKey("right") && Input.GetKey("down"))
        {
            GoX();
            BackY();
        }
        else if (Input.GetKey("right") && Input.GetKey("up"))
        {
            GoX();
            GoY();
        }
        else if (Input.GetKey("left") && Input.GetKey("right"))
        {
        }
        else if (Input.GetKey("up") && Input.GetKey("down"))
        {
        }
        else if (Input.GetKey("left"))
        {
            BackX();
        }
        else if (Input.GetKey("right"))
        {
            GoX();
        }
        else if (Input.GetKey("up"))
        {
            GoY();
        }
        else if (Input.GetKey("down"))
        {
            BackY();
        }

        transform.position = position;
    }
}
