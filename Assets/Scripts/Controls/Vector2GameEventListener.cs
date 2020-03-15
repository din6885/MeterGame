using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Vector2GameEventListener : MonoBehaviour
{
    public Vector2GameEvent Event;

    public Vector2UnityEvent Response;


    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(Vector2 obj)
    {
        Response.Invoke(obj);
    }
}
