using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	public GameObject player;
	public GameObject gunObj;
	public GameObject bulletPrefab;
	public GameObject enemyPrefab;
	public GameObject explosionPrefab;
	public List<Transform> locations;
	public float spawnInterval;
	private float spawnElaseped;
	public GameObject gameOverPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log(player.transform.position);
		// Debug.Log(player.transform.TransformDirection(Vector3.forward));
		Vector3 force = player.transform.TransformDirection(Vector3.forward);

		if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0)){
			GameObject bulleetObj =  GameObject.Instantiate(bulletPrefab, gunObj.transform.position, gunObj.transform.rotation);
			bulleetObj.GetComponent<Rigidbody>().AddForce(2000*force);
			// Debug.Log("shoot");
		}

		spawnElaseped += Time.deltaTime;
		if (spawnElaseped >= spawnInterval) {
			spawnElaseped -= spawnInterval;
			SpawnEnemy();
		}
	}

	void SpawnEnemy() {
		int randomIdx = Random.Range(0, locations.Count);
		GameObject enemyObj =  GameObject.Instantiate(enemyPrefab, locations[randomIdx].transform.position, locations[randomIdx].transform.rotation);
		Enemy enemy = enemyObj.GetComponent<Enemy>();
		enemy.target = player;
		Vector3 vel = transform.position - enemyObj.transform.position;
		enemyObj.GetComponent<Rigidbody>().velocity = vel.normalized * 10;
	}

	public void Die() {
		gameOverPanel.SetActive(true);
		Debug.Log("die");
	}
}
