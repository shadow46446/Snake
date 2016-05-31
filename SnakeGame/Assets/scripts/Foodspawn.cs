using UnityEngine;
using System.Collections;

public class Foodspawn: MonoBehaviour {
	// Food Prefab
	public GameObject foodPrefab;
	
	// Borders
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	public float amountOfFood;
	public float x;
	public float y;

	public bool full;

	// Use this for initialization
	void Start () {
		// Spawn food every 4 seconds, starting in 3
		if(full == false){
			InvokeRepeating("Spawn", 3, 4);
		}
		amountOfFood = 0f;
		x = (int)Random.Range(borderLeft.position.x,
		                      borderRight.position.x);
		y = (int)Random.Range(borderBottom.position.y,
		                      borderTop.position.y);
	}
	
	// Spawn one piece of food
	void Spawn() {
		Instantiate(foodPrefab,
		            new Vector2(x, y),
		            Quaternion.identity); // default rotation
	}

	void Update(){
		if (foodPrefab.transform == Vector2(x,y)){
			amountOfFood = amountOfFood + 1;
		}
		
		if (amountOfFood == 10f){
			full = true;
		}
	}
}
