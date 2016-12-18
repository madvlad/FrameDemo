using UnityEngine;
using System.Collections;

public class OriginSelect : MonoBehaviour {
    public GameObject BuildingFrame;
    public GameObject OriginAnchor;

    private bool isPlacing = true;
	// Use this for initialization
	void Start() {
        Invoke("SendSelectMessage", 2);
    }

    void SendSelectMessage()
    {
        gameObject.SendMessage("OnSelect");
    }

    void OnSelect()
    {
        if (isPlacing)
        {
            isPlacing = false;
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("SpatialMapping"));
            var frame = Instantiate(BuildingFrame);
            frame.transform.position = OriginAnchor.transform.position;
            frame.transform.rotation = OriginAnchor.transform.rotation;
            Destroy(OriginAnchor);
        }
    }
}
