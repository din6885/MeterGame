using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMeter : Meter
{
    public IntReference playerOneCurrentLevel;

    void Update()
    {
        if (Current.Value >= Max.Value)
        {
            playerOneCurrentLevel.Value += 1;
            Current.Value = 0;
        }
    }
}
