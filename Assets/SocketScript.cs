using System;
using UnityEngine;

public class SocketScript : MonoBehaviour
{
    public Transform cableSocket;
    public bool isPluggedIn;
    [SerializeField] [Range(1,4)] private int socketValue;
    
    public void CheckCable(CablePinScript cable)
    {
        if (cable.cableValue == socketValue)
        {
            isPluggedIn = true;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
    }
}
