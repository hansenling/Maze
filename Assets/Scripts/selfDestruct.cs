using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
	public GameObject top;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroySelf(){
		Destroy(this);
		Destroy (top);

	}
}
