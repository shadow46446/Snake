using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour {
	
	float speed = 150f;
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(-Vector2.right * speed * Time.deltaTime); 
			transform.rotation = Quaternion.Euler(0, 180, 0);
		}
		else if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-Vector2.right * speed * Time.deltaTime); 
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
	}
}