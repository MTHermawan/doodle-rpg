using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    public UnityEvent Events;

    public void invokeAll()
    {
        Events.Invoke();
    } 
}
