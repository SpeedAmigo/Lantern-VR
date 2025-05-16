using UnityEngine;

public class LightBulbScript : MonoBehaviour
{
    [SerializeField] private Transform bulbSocket;

    private Rigidbody _rb;

    public void OnCableDrop()
    {
        RaycastHit hit;
        if (Physics.Raycast(bulbSocket.position, bulbSocket.forward, out hit, 0.1f, LayerMask.GetMask("Socket")))
        {
            if (hit.collider.TryGetComponent<LightBulbSocketScript>(out var socket))
            {
                _rb.isKinematic = true;
                transform.position = socket.socketTransform.position;
                transform.rotation = socket.socketTransform.rotation;             
            }
        }
        else
        {
            _rb.isKinematic = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<LightBulbSocketScript>(out var socket))
        {
            _rb.isKinematic = true;
            transform.position = socket.socketTransform.position;
            transform.rotation = socket.socketTransform.rotation;      
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
