using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(HealthComponent))]
public class editorButtons : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
