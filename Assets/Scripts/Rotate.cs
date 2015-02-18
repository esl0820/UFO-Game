using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	float rotation = 125f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, rotation * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.left, rotation * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.right, rotation * Time.deltaTime);
		}
		if ( Input.GetKey (KeyCode.UpArrow) ) {
			transform.position += new Vector3( 0f, 2f, 0f) * Time.deltaTime;
		}
		//down when pressing shift
		if ( Input.GetKey (KeyCode.DownArrow) ) {
			transform.position += new Vector3( 0f, -2f, 0f) * Time.deltaTime;
		}
	
	}
}
