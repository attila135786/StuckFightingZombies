using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

	public float speed = 1f;
	public GameObject player;

	void Update () {
		// The step size is equal to speed times frame time.
		var step = speed * Time.deltaTime;

		// Move our position a step closer to the target.
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
	}

	//void OnTriggerEnter (Collider collider) {
	//	if (collider.gameObject.tag.Equals ("Bullet")) {
	//		Destroy (gameObject);
	//		Destroy (collider.gameObject);
	//		Debug.Log ("a Bullet collided with Zombie");						
	//	}
	//}
}
