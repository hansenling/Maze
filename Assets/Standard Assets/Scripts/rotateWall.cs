using UnityEngine;
using System.Collections;

public class rotateWall : MonoBehaviour {
	static Vector3 axis;
	static float currangle = 0;
	public float angle = 90;
	public int speed = 20;
	public float direction = 1;
	public bool myactive;
	// Use this for initialization
	void Start () {
		Vector3 axis = this.transform.position;
		myactive = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (currangle < angle && myactive) {
			currangle += speed * Time.deltaTime;
			this.transform.Rotate(0, speed * Time.deltaTime * direction,0 );
		} else{
			currangle = 0;
			myactive = false;
		}
	}
}
