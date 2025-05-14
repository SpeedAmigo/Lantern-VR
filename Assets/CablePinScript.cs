using System;
using UnityEngine;

public class CablePinScript : MonoBehaviour
{
    [Range(1,4)] public int cableValue;
    [SerializeField] private Transform cableSocket;

    private Rigidbody _rb;

    public void OnCableDrop()
    {
        RaycastHit hit;
        if (Physics.Raycast(cableSocket.position, cableSocket.forward, out hit, 0.1f))
        {
            if (hit.collider.TryGetComponent<SocketScript>(out var socket))
            {
                _rb.isKinematic = true;
                transform.position = socket.cableSocket.position;
                transform.rotation = socket.cableSocket.rotation;
                socket.CheckCable(this);
            }
        }
        else
        {
            _rb.isKinematic = false;
        }
    }
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
