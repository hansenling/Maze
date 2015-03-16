using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAttributes : MonoBehaviour {
	public List<GameObject> keys = new List<GameObject>();
	public Vector3 lastPosition;
	public Vector3 myVelocity;
	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		myVelocity = transform.position - lastPosition;
		myVelocity = new Vector3 (myVelocity.x, myVelocity.y, myVelocity.z);
		lastPosition = transform.position;
	}
	public void addKey (GameObject key){
		keys.Add (key);
	}

	public void drawKeys(){
		int currKey = 0;
		for (int i =0; i < keys.Count; i++) {

			if (keys[i]){
				if (keys[i].GetComponent<Key>().set == false){
					Vector3 keyPosition = this.gameObject.transform.position;
					
					keyPosition += this.gameObject.transform.forward;
					
					keyPosition.x -= this.gameObject.transform.forward.x * .75f;
					keyPosition.z -= this.gameObject.transform.forward.z * .75f;
					Vector3 temp = this.gameObject.transform.forward;
					temp = Quaternion.AngleAxis (90, Vector3.up) * temp;
					print (this.gameObject.transform.forward);
					print (temp);
					if (keys[i].GetComponent<Key>().scaled == false){
						keys[i].gameObject.transform.localScale -= new Vector3 (.43f, .43f, .43f);
						keys[i].GetComponent<Key>().scaled = true;
					}
					keyPosition.y += .7f;
					keyPosition.x -= temp.x * .2f;
					keyPosition.z -= temp.z * .2f;
					keyPosition.x += temp.x * currKey * .1f;
					keyPosition.z += temp.z * currKey * .1f;
					
					keys[i].gameObject.transform.parent = this.gameObject.transform;
					keys[i].gameObject.transform.position = keyPosition;
					keys[i].GetComponent<Key>().set = true;
				}
				currKey+=1;
				print (currKey);
			}
		}
	}
	public void removeKey(Color color, GameObject locked){
		for (int i = 0; i < keys.Count; i++) {

			if (keys[i].GetComponent<Key>().color == color){
				for (int a = 0; a < keys.Count; a++) {
					if (keys[a]){
						keys[a].GetComponent<Key>().set = false;
					}
				}
				Destroy (keys[i]);

				keys.RemoveAt(i);
				drawKeys();
				print(keys);
				Destroy (locked);
			}
		}
	}
}
