using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayCycle : MonoBehaviour
{

    public float rotationPeriod; // Seconds it takes to rotate one period
    void Update()
    {
        // Rotate the sphere around its local y-axis
        transform.Rotate(Vector3.up * 360 / rotationPeriod * Time.deltaTime);
    }

}
