using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    float speed = 15.0f;
    float rotationSpeed = 100.0f;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        // used Vector3.left because Vector3.right causes the keys to invert the directions, so up is down and down is up
        transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed * verticalInput);
    }
}
