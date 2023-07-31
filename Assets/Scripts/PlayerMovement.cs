using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    private Touch touch;
    [SerializeField]
    private float movementSpeed;
    private float minX; 
    private float maxX;



    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed,
                transform.position.y, transform.position.z);

                float newX = transform.position.x + touch.deltaPosition.x * speed;

                float clampedX = Mathf.Clamp(newX, -3.5f, 5.4f);
                transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
            }


        }
        transform.Translate(0, 0, 1 * movementSpeed * Time.deltaTime);

    }
}
