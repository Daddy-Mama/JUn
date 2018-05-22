using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatfor : MonoBehaviour {

	[SerializeField]
	private float speed	= 3f;


	void Update(){

		if (transform.position.x < -10.2f) {
			Destroy (gameObject);
		}

		transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
	} 
}
