using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Calculate the new position by moving left based on Time.deltaTime
        transform.position += Vector3.left * Time.deltaTime * 5f;

        // Update the object's position
    }
}
