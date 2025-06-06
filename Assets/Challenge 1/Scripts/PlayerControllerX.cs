﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);

        //tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput * -1);
    }
}
