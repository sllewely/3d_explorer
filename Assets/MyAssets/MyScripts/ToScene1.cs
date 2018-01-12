﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene1 : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider objectCollided) {
		if (objectCollided.gameObject == player.gameObject) {
//			Debug.Log ("Change scene");
			SceneManager.LoadScene("Scene_01");
		}
	}

}
