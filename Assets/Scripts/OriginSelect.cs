using UnityEngine;
using System.Collections;

public class OriginSelect : MonoBehaviour {
    public GameObject BuildingFrame;

	// Use this for initialization
	void Start () {
        var newBuilding = Instantiate(BuildingFrame);

        // Show origin select prefab and wait for that to be placed, then place the BuildingFrame object
	}
}
