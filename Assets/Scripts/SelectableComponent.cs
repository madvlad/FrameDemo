using UnityEngine;
using System.Collections;

public class SelectableComponent : MonoBehaviour {

    private string ComponentName;
    private string ComponentDimensions;
    private string ComponentWeight;
    private int ComponentColor;

	void Start ()
    {
        ComponentName = "Wooden Joist";
        ComponentDimensions = "3' x 3' x 9'";
        ComponentWeight = "50lb";
        ComponentColor = 0;
	}
	
    void OnSelect()
    {
        // Show billboard in the direction of player and send object reference
        Debug.Log(ComponentName + " Selected");
    }
}
