using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMeter : Meter
{
    public IntReference playerOneCurrentLevel;

    public GameEvent LevelUpEvent;

    void Update()
    {
        if (Current.Value >= Max.Value)
        {
            playerOneCurrentLevel.Value += 1;
            Current.Value = 0;
            LevelUpEvent.Raise();
        }

        MeterFill();

    }
}
