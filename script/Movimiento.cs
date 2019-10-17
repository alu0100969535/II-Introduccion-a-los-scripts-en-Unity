using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float rotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        float horizontalAxis = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        float rotationLeft = Input.GetKey(KeyCode.Q) ? -rotationSpeed * Time.deltaTime : 0;
        float rotationRight = Input.GetKey(KeyCode.E) ? rotationSpeed * Time.deltaTime : 0;

        float rotationTotal = rotationLeft + rotationRight;

        this.transform.Translate(horizontalAxis, 0, verticalAxis);
        this.transform.Rotate(0, rotationTotal, 0);

    }
}
