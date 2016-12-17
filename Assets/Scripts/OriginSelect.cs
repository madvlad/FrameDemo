using UnityEngine;
using System.Collections;

public class OriginSelect : MonoBehaviour {
    public GameObject BuildingFrame;
    public GameObject OriginAnchor;

    private bool isPlacing = true;
	// Use this for initialization
	void Start() {
        OriginAnchor.SendMessage("OnSelect");
	}

    void OnSelect()
    {
        if (isPlacing)
        {
            isPlacing = false;
        } else
        {
            Debug.Log("Origin Set");
            var frame = Instantiate(BuildingFrame);
            BuildingFrame.transform.position = OriginAnchor.transform.position;
            Destroy(OriginAnchor);
        }
    }
}
