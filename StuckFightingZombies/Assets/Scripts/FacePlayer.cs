using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RotateSprite ();
	}

	void RotateSprite(){
		float angle = ComputeAngleFromDirectionVector ();
		transform.rotation = Quaternion.Euler (0, 0, angle + 180);
	}

	private float ComputeAngleFromDirectionVector(){
		Vector2 playerPosition = Camera.main.WorldToScreenPoint (player.transform.position);
		Vector3 positionVector3 = Camera.main.WorldToScreenPoint (transform.position);

		Vector2 position = new Vector2(positionVector3.x, positionVector3.y);
		Vector2 dirVector = playerPosition - position;
		return Mathf.Atan2 (dirVector.y, dirVector.x) * Mathf.Rad2Deg;
	}
}
