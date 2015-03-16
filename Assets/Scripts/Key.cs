using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	public bool scaled = false;
	public bool set = false;
	public Color color;
	// Use this for initialization
	void Start () {
		this.renderer.material.color = color;
	}
	
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		//if (true == false) {
		//	print ("WOOOO");
		//	Vector3 keyPosition = other.gameObject.transform.position;

		//	keyPosition += other.gameObject.transform.forward;

		//	keyPosition.x -= other.gameObject.transform.forward.x * .75f;
		//	keyPosition.z -= other.gameObject.transform.forward.z * .75f;
		//	Vector3 temp = other.gameObject.transform.forward;
		//	temp = Quaternion.AngleAxis (90, Vector3.up) * temp;
		//	print (other.gameObject.transform.forward);
		//	print (temp);
		//	this.gameObject.transform.localScale -= new Vector3 (.43f, .43f, .43f);
		//	keyPosition.y += .7f;
		//	keyPosition.x -= temp.x * test;
		//	keyPosition.z -= temp.z * test;
		//	keyPosition.x += temp.x * other.gameObject.GetComponent<PlayerAttributes>().numKeys * .1f;
		//	keyPosition.z += temp.z * other.gameObject.GetComponent<PlayerAttributes>().numKeys * .1f;
		//	other.gameObject.GetComponent<PlayerAttributes>().numKeys +=1;

		//	this.gameObject.transform.parent = other.gameObject.transform;
		//	this.gameObject.transform.position = keyPosition;
		//	set = true;
		//	other.GetComponent<PlayerAttributes>().addKey(this.gameObject);
		//	other.GetComponent<PlayerAttributes>().drawKeys();
		//}
		other.GetComponent<PlayerAttributes>().addKey(this.gameObject);
		other.GetComponent<PlayerAttributes>().drawKeys();
		//other.GetComponent<PlayerAttributes> ().drawKeys ((GameObject)Instantiate(this.gameObject,this.gameObject.transform.position,Quaternion.identity ));
	}

}
