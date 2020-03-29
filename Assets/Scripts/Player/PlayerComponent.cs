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

    public PlayerDataList PlayerDataList;

    private PlayerData PlayerData;

    public GameObject PointerObject;

    public GameObject PlayerScreenObject;

  private void OnEnable() 
    {

        PlayerPanel = GameObject.FindWithTag("PlayerPanel");
        NPCPanel = GameObject.FindWithTag("NPCPanel");
        OnPlayerJoined();
    }


    public void OnPlayerJoined()
    {

        PlayerScreenObject = Instantiate(PlayerScreenPrefab, PlayerPanel.transform);
        PlayerScreen playerScreen = PlayerScreenObject.GetComponent<PlayerScreen>();
        PointerObject = Instantiate(PlayerPointerPrefab, NPCPanel.transform);
        PlayerPointer playerPointerComponent = PointerObject.GetComponent<PlayerPointer>();
        

        for (int i = 0; i < PlayerDataList.playerDatas.Count;)
        {
            if (PlayerDataList.playerDatas[i].PlayerObject != null)
            {
                i++;

            }
            else
            {
                PlayerDataList.playerDatas[i].PlayerObject = gameObject;
                PlayerData = PlayerDataList.playerDatas[i];
                PlayerData.InitAsset();
                playerPointerComponent.PlayerData = this.PlayerData;
                playerScreen.PlayerData = this.PlayerData;
                return;
            } 

        }

    }


    

}