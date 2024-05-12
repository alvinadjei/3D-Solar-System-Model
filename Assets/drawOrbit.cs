using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawEllipticalPath : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int numPoints = 360;
    private float a;
    private float b;
    public float e = 0f;
    public Transform targetPlanet;


    void Start()
    {
        DrawPath();
    }

    void DrawPath()
    {
        Vector3[] positions = new Vector3[numPoints];

        a = targetPlanet.localPosition.x;
        b = Mathf.Sqrt(-a*a * (e*e - 1));

        for (int i = 0; i < numPoints; i++)
        {
            float angle = 2f * Mathf.PI * i / numPoints;
            float x = a * Mathf.Cos(angle);
            float z = b * Mathf.Sin(angle);
            positions[i] = new Vector3(x, 0f, z);
        }

        lineRenderer.positionCount = numPoints;
        lineRenderer.SetPositions(positions);
    }
}