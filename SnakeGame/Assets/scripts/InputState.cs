using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

	public bool actionButton;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;
	public float speed = 250f;

	private Rigidbody2D body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		actionButton = Input.GetKeyDown (KeyCode.Space);
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (-Vector2.right * speed * Time.deltaTime); 
			transform.rotation = Quaternion.Euler (0, 180, 0);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-Vector2.right * speed * Time.deltaTime); 
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);

		standing = absVelY <= standingThreshold;
	}
}
