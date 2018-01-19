using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Enemy : MonoBehaviour {

	public float health;
	public void TakeDamage(float damageAmount) {
		health -= damageAmount;

		if (health <= 0) {
			Die ();
		}
	}

	void Die() {
		Destroy (gameObject);
	}
}
