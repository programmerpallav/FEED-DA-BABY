using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.01f;
    public float accX = 2f;
    private Touch touch;
    public float movementSpeed;
    public float rotationSpeed;
    private float minX; 
    private float maxX;
    private float currentVelocity = 0f;



    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                currentVelocity += touch.deltaPosition.x * accX * Time.deltaTime;

                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed,
                transform.position.y, transform.position.z);

                transform.Rotate(0f, 0f, touch.deltaPosition.x * -1 * rotationSpeed);

                float newX = transform.position.x + currentVelocity * speed * Time.deltaTime;

                float clampedX = Mathf.Clamp(newX, -3.5f, 5.4f);
                transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
            }


        }
        transform.Translate(0, 0, 1 * movementSpeed * Time.deltaTime);

    }

    //rotate plane on z axis.
    //when drag left, it rotates anticlockwise. when drag right, it rotates clockwise.
}
