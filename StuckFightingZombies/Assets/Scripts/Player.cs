using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bulletSocket;
	public Rigidbody bullet;
	public float bulletSpeed = 10;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RotatePlayerSprite();
			ShootBullet ();
		}
	}

	void RotatePlayerSprite(){
		float angle = ComputeAngleFromDirectionVector ();
		transform.rotation = Quaternion.Euler (0, 0, angle);
	}

	private float ComputeAngleFromDirectionVector() {
		Vector2 mousePosition = Input.mousePosition;
		Vector3 playerPositionVector3 = Camera.main.WorldToScreenPoint (transform.position);

		Vector2 playerPosition = new Vector2(playerPositionVector3.x, playerPositionVector3.y);
		Vector2 dirVector = mousePosition - playerPosition;
		return Mathf.Atan2 (dirVector.y, dirVector.x) * Mathf.Rad2Deg;
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.tag.Equals ("Zombie")) {
			Debug.Log ("Zombie collided with player");
		}
	}

	private void ShootBullet() {
		Rigidbody bulletClone = Instantiate (bullet, bulletSocket.transform.position, bulletSocket.transform.rotation);
		bulletClone.velocity = bulletSocket.transform.right * bulletSpeed;
	}
}
