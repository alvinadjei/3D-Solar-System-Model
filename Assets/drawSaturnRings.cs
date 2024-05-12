using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawSaturnRings : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int numPoints = 360;
    public float r = 0.1f;

    // void Start()
    // {
    //     DrawRings();
    // }

    void Update()
    {
        DrawRings();
    }

    void DrawRings()
    {
        Vector3[] positions = new Vector3[numPoints];

        // Get the parent object's position as the center of the rings
        Vector3 center = transform.parent.position;

        for (int i = 0; i < numPoints; i++)
        {
            float angle = 2f * Mathf.PI * i / numPoints;
            float x = center.x + r * Mathf.Cos(angle);
            float z = center.z + r * Mathf.Sin(angle);
            positions[i] = new Vector3(x, 0f, z);
        }

        lineRenderer.positionCount = numPoints;
        lineRenderer.SetPositions(positions);
    }
}