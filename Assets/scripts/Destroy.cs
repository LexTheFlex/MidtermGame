using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public GameObject player;
	public GameObject human;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag=="player")
			Destroy(human.gameObject);
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
