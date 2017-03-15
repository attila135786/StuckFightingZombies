using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Started");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			//transform.Rotate (Vector3.forward * Time.deltaTime * 10);
			Vector2 mousePosition = Input.mousePosition;
			Vector3 playerPositionVector3 = Camera.main.WorldToScreenPoint (transform.position);

			Vector2 playerPosition = new Vector2(playerPositionVector3.x, playerPositionVector3.y);
			Vector2 dirVector = mousePosition - playerPosition;
			var angle = Mathf.Atan2 (dirVector.y, dirVector.x) * Mathf.Rad2Deg;

			Debug.Log (angle);
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	}
}
