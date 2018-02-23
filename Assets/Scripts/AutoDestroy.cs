using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {
	float elasped;
	public float lifeTime = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (elasped > lifeTime) {
			Destroy(this.gameObject);
		}
	}
}
