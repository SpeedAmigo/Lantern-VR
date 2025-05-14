using System;
using UnityEngine;

public class SocketScript : MonoBehaviour
{
    public Transform cableSocket;
    public bool isPluggedIn;
    [SerializeField] [Range(1,4)] private int socketValue;
    [SerializeField] private SocketParentScript parent;
    
    public void CheckCable(CablePinScript cable)
    {
        if (cable.cableValue == socketValue)
        {
            isPluggedIn = true;
            Debug.Log("Plugged in");
            parent.CheckSockets();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        //if (!other.gameObject.TryGetComponent<CablePinScript>(out var cable)) return;

        if (isPluggedIn)
        {
            isPluggedIn = false;
            Debug.Log("Unplugged");
        }
    }
}
