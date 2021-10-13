using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(StateManager), true)]
public class stateButtons : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        /*if (GUILayout.Button("next state"))
        {
            
            var stateManager = target as StateManager;
            stateManager?.ChangeState(stateManager?.nextStateTest);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
