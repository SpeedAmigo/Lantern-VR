using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

public class SocketParentScript : MonoBehaviour
{
    [SerializeField] private List<SocketScript> socketList;
    [SerializeField] private UnityEvent onAllPluggedIn;

    public void CheckSockets()
    {   
        bool allPlugged = socketList.All(socket => socket.isPluggedIn);

        if (allPlugged)
        {
            onAllPluggedIn?.Invoke();
        }
    }
}
