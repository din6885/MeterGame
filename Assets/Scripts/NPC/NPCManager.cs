using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using System;

public class NPCManager : MonoBehaviour
{
    public NPCRuntimeSet runtimeSet;

    public NPCRuntimeSet NPCDeactiveSet;

    public IntVariable CurrentNPCCount;

    public FloatReference RespawnSeconds;

    public NPCStatsReference NPCStatsReference;

    //public event Func<IEnumerator> CoroutineOnEvents;

    void OnDisable()
    {
        NPCDeactiveSet.Items = null;
    }

    public void OnActionPhase()
    {
               
        if (NPCStatsReference != null)
        {
            StartCoroutine("Spawn", NPCStatsReference.CurrentNPCStats);
        }
       
        // StartCoroutine "MinusAction(target)"
    }



    IEnumerator Spawn(NPCStats stats)
    {
        for (;CurrentNPCCount.value > 0;)
        {
            if (NPCDeactiveSet.Items.Count != 0)
            {
                NPC Obj = NPCDeactiveSet.Items[0];
                Obj.gameObject.SetActive(true);
                
                Obj.OnSpawn(stats);

                NPCDeactiveSet.Remove(Obj);
                CurrentNPCCount.value -= 1;
            }
            yield return new WaitForSeconds(RespawnSeconds.Value);
        }
    }


}
