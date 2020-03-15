using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NPCRuntimeSet : RuntimeSet<NPC>
{
    public NPC SelectedNPC;

    public void Delete(NPC obj)
    {
        Destroy(obj.gameObject);
    }

   
}

