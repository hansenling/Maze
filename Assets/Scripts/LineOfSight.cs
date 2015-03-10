using UnityEngine;
using System.Collections;

public class LineOfSight : MonoBehaviour {
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		for (int y = -10; y<11; y++) {
			for (int x = -160; x < 161; x++) {
				if (Physics.Raycast (transform.position, fwd + new Vector3 (((float)x / 100.0f), (float)y/100.0f,0 ), out hit, 100)) {
					if (hit.collider.gameObject.tag == "fogOfWar") {
						(hit.collider.gameObject.GetComponent<selfDestruct> ()).destroySelf ();
					}
				}
			}
		}
	}
}
