using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;
	public Transform camera;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x, player.position.y, -10); // Camera follows the player but 6 to the right
		if (player.position.y < -2600) 
		{
			transform.position = new Vector3 (camera.position.x, (camera.position.y + 300), -10);
		}
	}
}