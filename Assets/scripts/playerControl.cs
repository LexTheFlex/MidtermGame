using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0, 1) * moveSpeed *Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= new Vector3 (0, 0, 1) * moveSpeed *Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0) * moveSpeed *Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= new Vector3 (1, 0, 0) * moveSpeed *Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.Space)) {
			transform.position += new Vector3 (0, 0, 3) * moveSpeed * Time.deltaTime;
		} 

		//Rigidbody rbody = GetComponent<Rigidbody> ();


	
	}
}
