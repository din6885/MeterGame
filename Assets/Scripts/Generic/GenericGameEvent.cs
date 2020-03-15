using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericGameEvent<T> : ScriptableObject
{
    public List<T> listeners = new List<T>();

    public void RegisterListener(T listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(T listener)
    {
        listeners.Remove(listener);
    }
}
