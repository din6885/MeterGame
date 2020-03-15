using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NPC/NPCStatsReference")]
public class NPCStatsReference : ScriptableObject
{
    public List<NPCStats> NPCStatsList;
    public NPCStats CurrentNPCStats;
}
