using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {

			collider.gameObject.transform.position = new Vector3 (0f, -10f, 0f);
		}
	}
}
