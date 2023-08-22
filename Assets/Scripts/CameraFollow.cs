using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset;
    Vector3 newpos;
    public GameObject playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        offset = playerCharacter.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newpos = transform.position;
        newpos.x = playerCharacter.transform.position.x - offset.x;
        newpos.z = playerCharacter.transform.position.z - offset.z;
        transform.position = newpos;

    }
}
