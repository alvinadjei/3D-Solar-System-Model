using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ellipticalOrbit : MonoBehaviour
{

    private float a; // The semi-major axis of the orbit
    private float b; // The semi-minor axis of the orbit
    // Record 
    public float orbitPeriod = 1f; // The speed of the orbit 
    public float e = 1f; // Eccentricity of orbit

    // Start is called before the first frame update
    void Start()
    {
        // Get the starting x-value of the sphere
        a = Mathf.Abs(transform.localPosition.x) * transform.parent.localScale.x;
        b = Mathf.Sqrt(-a*a * (e*e - 1));
    }

    // Update is called once per frame
    void Update()
    {

        // Get the parent object's position as the center of the rings
        Vector3 center = transform.parent.position;

        // Increment the angle based on the orbit speed
        float angle = 2f * Mathf.PI / orbitPeriod * Time.time;

        // Calculate the position of the sphere in the orbit
        float x = center.x + a * Mathf.Cos(angle);
        float y = 0;
        float z = center.z + b * Mathf.Sin(angle);

        // Update the position of the sphere
        transform.position = new Vector3(x, y, z);
    }
}
