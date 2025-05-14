using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SocketParentScript : MonoBehaviour
{
    [SerializeField] private List<SocketScript> socketList;

    public void CheckSockets()
    {
        Debug.Log("Checking sockets");
        
        bool allPlugged = socketList.All(socket => socket.isPluggedIn);

        if (allPlugged)
        {
            Debug.Log("All sockets are plugged in");
        }
    }
}
