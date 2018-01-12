using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeUncouple : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter() {
		player.transform.parent = null;
	}

}
