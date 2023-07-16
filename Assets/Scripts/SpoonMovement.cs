using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    private Touch touch;
    [SerializeField]
    private float movementSpeed;


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

            }

            if(touch.phase == TouchPhase.Led)
            {

            }

        }
        transform.Translate(0, 0, 1 * movementSpeed * Time.deltaTime);

    }
}
