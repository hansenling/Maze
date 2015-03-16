using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
	public GameObject destination;
	public Vector3 offset;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		Vector3 temp = other.GetComponent<PlayerAttributes> ().myVelocity;
		offset = new Vector3 (temp.x, 0, temp.z);
		offset.Normalize ();
		offset = offset * 1.1f;
		other.transform.position = destination.transform.position + offset;
		//other.transform.position += offset;//Vector3(destination.transform.position.x+1, destination.transform.position.y, destination.transform.position.z);
	}
}
