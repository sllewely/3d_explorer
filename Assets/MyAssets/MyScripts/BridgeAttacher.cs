using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeAttacher : MonoBehaviour {

	public GameObject bridge;
	public GameObject player;

	void OnTriggerEnter() {
		player.transform.parent = bridge.transform;
	}

}
