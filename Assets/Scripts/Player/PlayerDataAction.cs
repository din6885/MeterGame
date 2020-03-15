using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerDataAction
{
    public float Value;
    public int Level;
    [Range(0,1)]
    public float LevelProgress;
}
