using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NPC : MonoBehaviour //ISelectHandler, IDeselectHandler
{
    public NPCGameEvent RedMeterEmpty;

    public NPCRuntimeSet NPCRuntimeSet;

    public Meter RedMeter;

    public NPCStats NPCStats;

    public float minusAction;

    public float minusActionTimer;

    public bool selected;

    void OnEnable()
    {
        NPCRuntimeSet.Add(this);
        selected = false;
        
    }

    void OnDisable()
    {
        NPCRuntimeSet.Remove(this);
        
    }

    public void OnSpawn(NPCStats stats)
    {
        NPCStats = stats;

        if(NPCStats != null)
        {
            RedMeter.Max.Value = NPCStats.redMeterMax;
            RedMeter.Current.Value = NPCStats.redMeterMax;
            minusAction = NPCStats.minusAction;
            minusActionTimer = NPCStats.minusActionTimer;
        }
    }

    void MinusAction()
    {
        //ToDo Start Minus Random Player when timer 0;
    }

    //public void OnSelect(BaseEventData baseEvent)
    //{
    //    NPCRuntimeSet.SelectedNPC = this;
    //    selected = true;
    //}



    //public void OnDeselect(BaseEventData baseEvent)
    //{
    //    NPCRuntimeSet.SelectedNPC = null;
    //    selected = false;
    //}

    public void OnMinus(float value)
    {
        RedMeter.MinusMeter(value);
        if (RedMeter.Current.Value <= 0.0f)
        {
            OnRedEmpty();
        }
    }

    public void OnRedEmpty()
    {
        this.gameObject.SetActive(false);

        RedMeterEmpty.Raise(this);
    }
}
