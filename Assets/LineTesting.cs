using UnityEngine;

public class LineTesting : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineController lineController;
    [SerializeField] private Color color;

    private void Start()
    {
        lineController.SetUpLine(points, color);
    }
}
