using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(player.transform.position);
		Debug.Log(player.transform.TransformDirection(Vector3.forward));
		if (Input.GetKeyDown(KeyCode.F)){
			Debug.Log("shoot");
		}
	}
}
