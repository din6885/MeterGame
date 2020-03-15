using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter : MonoBehaviour
{
    public FloatReference Current;

    public FloatReference Max;

    public GameObject SpriteMask;

    public void MeterFill()
    {
        SpriteMask.transform.localScale = new Vector3(Mathf.Clamp01(Current.Value / Max.Value), 1.0f);
    }

    public void MinusMeter(float value)
    {
        Current.Value -= Mathf.Clamp(value, 0.0f, Max.Value);
    }

    public void PlusMeter (float value)
    {
        Current.Value += Mathf.Clamp(value, 0.0f, Max.Value);

    }

    void Update()
    {

        MeterFill();
    }
}
