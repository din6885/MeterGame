using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerPointer : MonoBehaviour
    {
    public RectTransform Panel;

    private RaycastHit2D Hit2D;

    private GameObject Selection;

    public void Awake()
    {
        if (Panel == null)
        {
            Panel = this.transform.parent.GetComponentInParent<RectTransform>();
        }
    }

    public GameObject PlayerPointerSelection(InputValue value)
        {

        Vector2 axisInput = value.Get<Vector2>();

        //Debug.Log(pointerposition);
        float xposition = axisInput.x * (Panel.rect.width / 3.0f);
        float yposition = axisInput.y * (Panel.rect.height / 3.0f);
        this.transform.localPosition = new Vector2(xposition, yposition);
        Hit2D = Physics2D.Raycast(this.transform.position, Vector3.forward);

        if (Hit2D.collider != null)
        {
            Selection = Hit2D.collider.gameObject;
        }
        else
        {
            Selection = null;
        }
        return Selection;
        }
    }

