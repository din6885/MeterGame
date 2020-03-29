using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerPointer : MonoBehaviour
{
    public RectTransform Panel;

    private RaycastHit2D Hit2D;

    public GameObject Selection;

    public PlayerData PlayerData;

    private PlayerOneInput InputAction;

    

    public void Awake()
    {
        InputAction = new PlayerOneInput();
        InputAction.PlayerControl.Point.performed += ctx => OnPoint(ctx.ReadValue<Vector2>());
        InputAction.PlayerControl.Cross.performed += ctx => OnCross();

        if (Panel == null)
        {
            Panel = this.transform.parent.GetComponentInParent<RectTransform>();
        }
    }

    void OnEnable()
    {
        InputAction.Enable();
    }

    void OnDisable()
    {
        InputAction.Disable();
    }

    public void OnPoint(Vector2 axisInput)
    {

        float xposition = Mathf.Clamp(axisInput.x * Panel.rect.width, -4.0f, 4.0f);
        float yposition = Mathf.Clamp(axisInput.y * Panel.rect.height, -4.0f, 4.0f);
        this.transform.localPosition = new Vector2(xposition, yposition);
        Hit2D = Physics2D.Raycast(this.transform.position, Vector3.forward);

        if (Hit2D.collider != null)
        {
            this.Selection = Hit2D.collider.gameObject;
        }
        else
        {
            this.Selection = null;
        }

    }

    public void OnCross()
    {
        if (Selection != null)
        {
            if (Selection.activeInHierarchy)
            {
                Selection.GetComponent<NPC>().OnMinus(PlayerData.Minus.Value);
            }

        }
    }
}

