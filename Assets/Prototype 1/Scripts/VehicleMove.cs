using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    private float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
