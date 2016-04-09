using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Detect Collision
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("IsHitable")) {
			Debug.Log ("Hit!");
			other.gameObject.GetComponentInParent<Rigidbody> ().AddForce(Vector3.up * 1000);
		}
	}
}
