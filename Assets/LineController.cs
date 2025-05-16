using System;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points, Color color)
    {
        lr.positionCount = points.Length;
        this.points = points;

        lr.startColor = color;
        lr.endColor = color;
    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
