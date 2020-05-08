using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerDataAction
{
    public float Value
    {
        get
        {
            return 10.0f + (level * 10.0f);
        }
    }

    public int level;
    [Range(0,1)]
    public float levelProgress;

    public void Progress(float gain)
    {
        levelProgress += gain;
        if (levelProgress == 1)
        {
            level += 1;
            levelProgress = 0.0f;
        }
    }
}
