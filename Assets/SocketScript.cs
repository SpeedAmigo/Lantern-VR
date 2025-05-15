using System;
using UnityEngine;

public class SocketScript : MonoBehaviour
{
    public Transform cableSocket;
    public bool isPluggedIn;
    [SerializeField] [Range(1,6)] private int socketValue;
    [SerializeField] private SocketParentScript parent;
    
    public void CheckCable(CablePinScript cable)
    {
        if (cable.cableValue == socketValue)
        {
            isPluggedIn = true;
            parent.CheckSockets();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (isPluggedIn)
        {
            isPluggedIn = false;
        }
    }
}
