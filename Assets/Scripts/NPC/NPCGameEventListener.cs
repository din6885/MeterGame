using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPCGameEventListener : MonoBehaviour
{
    public NPCGameEvent Event;

    public NPCUnityEvent Response;


    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(NPC obj)
    {
        Response.Invoke(obj);
    }
}
