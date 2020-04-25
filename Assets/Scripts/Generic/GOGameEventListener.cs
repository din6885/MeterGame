using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOGameEventListener : MonoBehaviour
{
    public GOGameEvent Event;

    public GOUnityEvent Response;


    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(GameObject obj)
    {
        Response.Invoke(obj);
    }
}
