using UnityEngine;
using System.Collections;

public class trapActivator : MonoBehaviour {
	public GameObject trapObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.collider.tag == "Player") {
			(trapObject.GetComponent<trap> ()).up = true;
			(trapObject.GetComponent<trap> ()).springTrap ();
		}
	}
}
