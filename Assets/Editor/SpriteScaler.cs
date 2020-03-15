using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(SpriteScaleComponent))]
public class SpriteScaler : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        //GUI.enabled = Application.isPlaying;

        if (GUILayout.Button("Scale"))
        {
            SpriteScaleComponent spriteRenderer = target as SpriteScaleComponent;

            spriteRenderer.keepScaleRelativeToParent();
        }

    }

}
