using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	public GameObject myWall;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		(myWall.GetComponent<rotateWall>()).isActive = true;
	}
}
