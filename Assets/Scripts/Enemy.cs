using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	Rigidbody body;
	public GameObject target;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody>();
		// this.GetComponent<Rigidbody>.velocity = 

	}
	
	void FixedUpdate() {
		Vector3 relativePos = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;
		// Transform.LookAt(, )
		// Debug.Log("Update");
	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
        	GameObject.Instantiate(explosionPrefab, transform.position, transform.rotation);
        	collision.gameObject.GetComponent<PlayerManager>().Die();
        	Destroy(this.gameObject);
        }
    }
}
