using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerComponent : MonoBehaviour
{
    //Reference
    public PlayerData PlayerData;

    public GameObject Pointer;

    public PlayerPointer PlayerPointerComponent;

    public GameObject PlayerScreen;

    public GameObject PlayerSkillScreen;

    //OnPointAction
    public GameObject Selection;

    public void OnPoint(InputValue value)
    {
        Selection = PlayerPointerComponent.PlayerPointerSelection(value);

    }

    public void OnCross()
    {
        if (Selection != null)
        {
            if (Selection.activeInHierarchy)
            {
                Selection.GetComponent<NPC>().OnMinus(10.0f);
            }

        }
    }

    public void OnSquare()
    {
        //PlayerMeter.transform.Find("RedMeter").GetComponent<Meter>().PlusMeter(10.0f);
    }

    public void OnCircle()
    {

    }

}