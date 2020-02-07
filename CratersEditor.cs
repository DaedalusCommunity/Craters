#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Craters))]
public class CratersEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Craters myScript = (Craters)target;
        if (GUILayout.Button("Crater"))
        {
            myScript.GenCrater();
        }

        if (GUILayout.Button("Smooth"))
        {
            myScript.Smooth();
        }
        if (GUILayout.Button("Rain"))
        {
            myScript.MakeItRain();
        }

    }
}
#endif
