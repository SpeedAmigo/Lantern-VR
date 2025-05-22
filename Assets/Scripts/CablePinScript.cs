using System;
using UnityEngine;

public class CablePinScript : MonoBehaviour
{
    [Range(1,6)] public int cableValue;
    [SerializeField] private Transform cableSocket;

    [SerializeField] private AudioClip cableSound;
    
    private AudioSource audioSource;
    private Rigidbody _rb;

    public void OnCableDrop()
    {
        RaycastHit hit;
        if (Physics.Raycast(cableSocket.position, cableSocket.forward, out hit, 0.1f, LayerMask.GetMask("Socket")))
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<SocketScript>(out var socket))
        {
            _rb.isKinematic = true;
            transform.position = socket.cableSocket.position;
            transform.rotation = socket.cableSocket.rotation;
            audioSource.PlayOneShot(cableSound);
            socket.CheckCable(this);
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
}
