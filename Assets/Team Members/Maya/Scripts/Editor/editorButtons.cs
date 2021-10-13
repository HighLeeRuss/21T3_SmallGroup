using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(StateBase), true)]
public class editorButtons : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI()
    {
        /*base.OnInspectorGUI();
        if (GUILayout.Button("Heal"))
        {
            (target as HealthComponent)?.Heal();
        }
        if (GUILayout.Button("Hurt"))
        {
            (target as HealthComponent)?.Damage();
        }
        if (GUILayout.Button("Murder"))
        {
            (target as HealthComponent)?.DeathFunction();
        }*/
        base.OnInspectorGUI();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Enter"))
        {
            (target as StateBase)?.Enter();
        }
        if (GUILayout.Button("Execute"))
        {
            (target as StateBase)?.Execute();
        }
        if (GUILayout.Button("Exit"))
        {
            (target as StateBase)?.Exit();
        }
        GUILayout.EndHorizontal();
    }
}
