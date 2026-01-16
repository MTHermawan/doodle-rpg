using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EventTester))]
public class EventTesterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EventTester eventTester = (EventTester)target;
        if (GUILayout.Button("Invoke"))
        {
            eventTester.invokeAll();
        }
    }
}