using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour {

	public GameObject platform;

	void Start(){
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn ()
	{
		while (true) {
			Instantiate (platform, new Vector2 (10.4f,Random.Range(-2.5f,2.5f)), Quaternion.identity);
			yield return new WaitForSeconds (1.5f);
		}
	
	}
}
