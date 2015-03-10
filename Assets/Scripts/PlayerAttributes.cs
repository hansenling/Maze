using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAttributes : MonoBehaviour {
	public int numKeys= 0;
	public List<GameObject> keys = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void addKey (GameObject key){
		keys.Add (key);
	}

	public void drawKeys(){
		int currKey = 0;
		for (int i =0; i < keys.Count; i++) {

			if (keys[i]){
				if (keys[i].GetComponent<Key>().set == false){
					print ("WOOOO");
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
					keyPosition.y += 1.1f;
					keyPosition.x -= temp.x * .4f;
					keyPosition.z -= temp.z * .4f;
					keyPosition.x += temp.x * currKey * .1f;
					keyPosition.z += temp.z * currKey * .1f;
					this.gameObject.GetComponent<PlayerAttributes>().numKeys +=1;
					
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
