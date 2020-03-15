using UnityEngine;

public class PlayerInputLegacy : MonoBehaviour
{


    public GameEvent CrossButtonPressedEvent;
    public GameEvent CircleButtonPressedEvent;
    public GameEvent TriangleButtonPressedEvent;
    public GameEvent SquareButtonPressedEvent;

    public Vector2GameEvent DPad;

    public float xAxisInput;
    public float yAxisInput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Cross"))
        {

            //Debug.Log("Key Cross pressed");
            CrossButtonPressedEvent.Raise();
        }

        if (Input.GetMouseButton(1))
        {
            CrossButtonPressedEvent.Raise();
        }

        if (Input.GetButton("Triangle")) 
        {
            TriangleButtonPressedEvent.Raise();
            //Debug.Log("Key Triangle pressed");
        }

        if (Input.GetButton("Circle"))
        {
            CircleButtonPressedEvent.Raise();
            //Debug.Log("Key Circle pressed");
        }

        if (Input.GetButton("Square"))
        {
            SquareButtonPressedEvent.Raise();
            //Debug.Log("Key Square pressed");
        }

        //xAxisInput = Input.GetAxisRaw("Horizontal");
        //yAxisInput = Input.GetAxisRaw("Vertical");

  
    }
}
