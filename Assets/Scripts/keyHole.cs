using UnityEngine;
using System.Collections;

public class keyHole : MonoBehaviour {
	public Color color;
	// Use this for initialization
	void Start () {
		this.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision){	
		if (collision.gameObject.tag == "Player"){
			collision.GetComponent<PlayerAttributes>().removeKey(color,this.gameObject);
		
		}
	}
}
