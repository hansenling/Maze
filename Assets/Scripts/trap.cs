using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {
	public float height = 5;
	static float starty;
	public bool up = false;
	// Use this for initialization
	void Start () {
		starty = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (up == true) {
			if (transform.position.y > 3) {
				lowerTrap ();
			}
			if (this.transform.position.y < starty) {
				rigidbody.velocity = new Vector3 (0, 0, 0);
				transform.position = new Vector3(transform.position.x, transform.position.y + .1f, transform.position.z);
				up = false;
			}
		}

	}
	public void springTrap(){ 
		this.rigidbody.velocity += new Vector3 (0, 10, 0);
	}
	void lowerTrap(){
		this.rigidbody.velocity = new Vector3 (0, -2, 0);
	}

	void OnTriggerEnter(Collider other){
		if (other.collider.tag == "Player") {
			Destroy (other.collider.gameObject);
			Application.Quit();
		}
	}
}
