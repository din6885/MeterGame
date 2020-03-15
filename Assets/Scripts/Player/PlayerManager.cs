using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    //Init
    public GameObject PlayerObjectPrefab;

    public GameObject PlayerPointerPrefab;

    public GameObject PlayerScreenPrefab;

    public GameObject PlayerSkillScreenPrefab;

    public GameObject PlayerPanel;

    public GameObject NPCPanel;

    public PlayerData[] PlayerDataAssets;

    public PlayerData PlayerDataAsset;

    //After OnPlayerJoined Init
    public void OnPlayerJoined(PlayerInput player)
    {
        GameObject Player = player.gameObject;
        PlayerComponent playerComponent = Player.GetComponent<PlayerComponent>();
        playerComponent.PlayerScreen = Instantiate(PlayerScreenPrefab, PlayerPanel.transform);
        playerComponent.PlayerSkillScreen = Instantiate(PlayerSkillScreenPrefab, playerComponent.PlayerScreen.transform);
        playerComponent.Pointer = Instantiate(PlayerPointerPrefab, NPCPanel.transform);
        playerComponent.PlayerPointerComponent = playerComponent.Pointer.GetComponent<PlayerPointer>();

        for (int i = 0; i < PlayerDataAssets.Length; ) 
        {
            if (PlayerDataAssets[i].PlayerObject != null)
            {
                i++;

            }
            else
            {
                PlayerDataAssets[i].PlayerObject = Player;
                playerComponent.PlayerData = PlayerDataAssets[i];
                PlayerDataAssets[i].InitAsset();
                return;
            }

        }

    }



}