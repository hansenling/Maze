using UnityEngine;
using System.Collections;

public class rotateWall : MonoBehaviour {
	static float currangle = 0;
	public float angle = 90;
	public int speed = 20;
	public float direction = 1;
	public bool isActive = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (currangle < angle && isActive) {
			currangle += speed * Time.deltaTime;
			this.transform.Rotate(0, speed * Time.deltaTime * direction,0 );
		} else{
			currangle = 0;
			isActive = false;
		}
	}
}
