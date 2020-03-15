using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScreenCounterGroup : MonoBehaviour
{
    public GameObject[] Counters;

    public int skill;

    public void InitCounters()
    {
        foreach (GameObject item in Counters)
        {
            item.SetActive(false);
        }
    }

    public void DisplayCountersBySkill (int svar)
    {
        for (int i = svar; i >= 0; i--)
        {
            Counters[i].SetActive(true);
        }
    }
}
