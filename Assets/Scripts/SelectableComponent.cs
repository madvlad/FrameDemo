using UnityEngine;
using System.Collections;

public class SelectableComponent : MonoBehaviour {

    public GameObject InfoBoardPrefab;

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
        var currentCursorPosition = GameObject.FindGameObjectWithTag("Cursor").transform.position;
        GameObject infoBoard = Instantiate(InfoBoardPrefab);
        infoBoard.transform.parent = gameObject.transform;
        infoBoard.transform.position = new Vector3(currentCursorPosition.x, currentCursorPosition.y, currentCursorPosition.z);
    }
}
