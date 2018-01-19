using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour {

	public float damage;
	public float range;

	public Camera playerCam;

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			FireRayCast ();
		}
		
	}

	RaycastHit hitInfo;

	void FireRayCast() {
		if (Physics.Raycast (playerCam.transform.position, playerCam.transform.forward, out hitInfo, range)) {
			Debug.Log ("I hit something");
			Debug.DrawRay (playerCam.transform.position, playerCam.transform.forward, Color.cyan);

			Target_Enemy enemy = hitInfo.transform.GetComponent<Target_Enemy> ();

			if (enemy != null) {
				enemy.TakeDamage (damage);
			}
		} else {
			Debug.Log ("Miss");
		}
	}
}
