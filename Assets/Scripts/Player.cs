using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform tardis = null;
	float speed = 45f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
		// move forward if I press W
		if ( Input.GetKey (KeyCode.W) ) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}

		// framerate dependent
		// if i have more FPS i go faster

		// FRAMERATE-INDEPENDENT
		// No Matter what you framerate, you get the same behavior
		// move backwards if I press S
		if ( Input.GetKey (KeyCode.S) ) {
			transform.Translate (Vector3.back * speed * Time.deltaTime);
		}

		// move left if I press A
		if ( Input.GetKey (KeyCode.D) ) {
			transform.RotateAround(tardis.position, Vector3.up, speed * Time.deltaTime);
		}
		if ( Input.GetKey (KeyCode.A) ) {
			transform.RotateAround(tardis.position, Vector3.down, speed * Time.deltaTime);
		}
		//if ( Input.GetKey (KeyCode.A) ) {
		//	transform.position += new Vector3( -speed, 0f, 0f) * Time.deltaTime;
		//}
		//if ( Input.GetKey (KeyCode.UpArrow) ) {
		//	transform.RotateAround(tardis.position, Vector3.right, 2*speed * Time.deltaTime);
		//}
		//if ( Input.GetKey (KeyCode.DownArrow) ) {
		//	transform.RotateAround(tardis.position, Vector3.left, 2*speed * Time.deltaTime);
		//}
		// move right if I press D
		//if ( Input.GetKey (KeyCode.D) ) {
		//	transform.position += new Vector3( speed, 0f, 0f) * Time.deltaTime;
		//}
		//up when pressing space
		if ( Input.GetKey (KeyCode.Space) ) {
			transform.position += new Vector3( 0f, speed, 0f) * Time.deltaTime;
		}
		//down when pressing shift
		if ( Input.GetKey (KeyCode.LeftShift) ) {
			transform.position += new Vector3( 0f, -speed, 0f) * Time.deltaTime;
		}
	}
}
