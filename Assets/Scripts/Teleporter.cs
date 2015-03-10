using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
	public GameObject destination;
	public Vector3 offset = new Vector3(1.0f, 0, 0);
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		other.transform.position = destination.transform.position + offset;
		//other.transform.position += offset;//Vector3(destination.transform.position.x+1, destination.transform.position.y, destination.transform.position.z);
	}
}
