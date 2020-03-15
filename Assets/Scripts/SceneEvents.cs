using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEvents : MonoBehaviour
{
    public GameEvent ActionPhase;
    public GameEvent MovementPhase;

    public IntVariable CurrentNPCCount;

    public List<IntVariable> NPCCountList;

    public NPCStatsReference NPCStatsReference;

    void Start()
    {
        CurrentNPCCount.value = NPCCountList[0].value;
        NPCStatsReference.CurrentNPCStats = NPCStatsReference.NPCStatsList[2];
        OnActionPhase();
    }

    public void OnActionPhase()
    {
        ActionPhase.Raise();
    }

    public void OnMovementPhase()
    {
        MovementPhase.Raise();
    }

    void OnDisable()
    {
        NPCStatsReference.CurrentNPCStats = null;
    }

}
