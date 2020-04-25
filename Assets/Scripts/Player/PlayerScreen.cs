using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScreen : MonoBehaviour
{
    public PlayerData PlayerData;

    public Meter RedMeter;
    public Meter BlueMeter;

    public SkillScreen skillScreen;

    private PlayerOneInput InputAction;

    public void Awake()
    {
        InputAction = new PlayerOneInput();
        InputAction.PlayerControl.Skills.performed += ctx => OnSkills();
        InputAction.PlayerControl.Skills.canceled += ctx => OnDeSkills();
    }
    void OnEnable()
    {
        InputAction.Enable();
    }

    void OnDisable()
    {
        InputAction.Disable();
    }

    public void OnDeSkills()
    {
        skillScreen.gameObject.SetActive(false);
    }
    public void OnSkills()
    {       
       skillScreen.gameObject.SetActive(true);   
    }

    

    }