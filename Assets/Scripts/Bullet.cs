using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -1000) {
			Destroy(this.gameObject);	
		}
	}

	void OnCollisionEnter(Collision collision)
    {
        GameObject.Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(this.gameObject);

        if (collision.gameObject.CompareTag("Enemy")) {
        	Destroy(collision.gameObject);
        }
    }
}
