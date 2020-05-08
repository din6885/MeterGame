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

    public float redMeterValue;

    public float blueMeterValue;

    public int freePoints;
   

    public void InitAsset()
    {
        Minus.value = 10.0f;
        Plus.value = 10.0f;
        Circle.value = 10.0f;
        Triangle.value = 10.0f;

        redMeterValue = 100.0f;
        blueMeterValue = 100.0f;
    }

    
}
