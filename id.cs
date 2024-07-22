using UnityEngine;

public class MyGUIScript : MonoBehaviour
{
    void OnGUI()
    {
        // Create a button at position (10, 10) with width 100 and height 50
        if (GUI.Button(new Rect(10, 10, 100, 50), "Click Me"))
        {
            Debug.Log("Button was clicked!");
        }

        // Create a label at position (10, 70) with width 200 and height 50
        GUI.Label(new Rect(10, 70, 200, 50), "This is a label");

        // Create a text field at position (10, 130) with width 200 and height 30
        string textFieldValue = "Enter text here";
        textFieldValue = GUI.TextField(new Rect(10, 130, 200, 30), textFieldValue);
    }
}
