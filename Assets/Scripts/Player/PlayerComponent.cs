using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerComponent : MonoBehaviour
{
    //Init

    public GameObject PlayerPointerPrefab;

    public GameObject PlayerScreenPrefab;

    public GameObject PlayerSkillScreenPrefab;

    //Reference
    private GameObject PlayerPanel;

    private GameObject NPCPanel;

    public PlayerData[] PlayerDataAssets;

    private PlayerData PlayerData;

    public GameObject Pointer;

    private PlayerPointer PlayerPointerComponent;

    private GameObject PlayerScreen;

    private GameObject PlayerSkillScreen;

    //OnPointAction
    public GameObject Selection;

    private void OnEnable() {
        PlayerPanel = GameObject.FindWithTag("PlayerPanel");
        NPCPanel = GameObject.FindWithTag("NPCPanel");
        OnPlayerJoined();
    }

    public void OnPlayerJoined()
    {

        PlayerScreen = Instantiate(PlayerScreenPrefab, PlayerPanel.transform);
        PlayerSkillScreen = Instantiate(PlayerSkillScreenPrefab, PlayerScreen.transform);
        Pointer = Instantiate(PlayerPointerPrefab, NPCPanel.transform);
        PlayerPointerComponent = Pointer.GetComponent<PlayerPointer>();

        for (int i = 0; i < PlayerDataAssets.Length;)
        {
            if (PlayerDataAssets[i].PlayerObject != null)
            {
                i++;

            }
            else
            {
                PlayerDataAssets[i].PlayerObject = gameObject;
                PlayerData = PlayerDataAssets[i];
                PlayerData.InitAsset();
                return;
            } 

        }

    }


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