using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public GameObject PlayerObject;

    public IntReference Level;

    public PlayerDataAction Minus;
   
    public PlayerDataAction Plus;

    public PlayerDataAction Circle;

    public PlayerDataAction Triangle;

    public Color color;
   

    public void InitAsset()
    {
        Minus.Value = 10.0f;
        Plus.Value = 10.0f;
        Circle.Value = 10.0f;
        Triangle.Value = 10.0f;
    }
}
