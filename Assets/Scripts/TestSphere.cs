using UnityEngine;

public class TestSphere : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}
