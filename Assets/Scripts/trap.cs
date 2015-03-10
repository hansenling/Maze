using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {
	public double height = 5;
	static double starty;
	public bool up = false;
	// Use this for initialization
	void Start () {
		starty = this.transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		if (up == true) {
			if (this.transform.position.y > 3) {
				lowerTrap ();
			}
			if (this.transform.position.y < starty) {
				this.rigidbody.velocity = new Vector3 (0, 0, 0);
				up = false;
			}
		}

	}
	public void getThere(){
		print ("GO");
		springTrap ();
	}
	void springTrap(){ 
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
