using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Player animator
	private Animator m_animator;

	// Use this for initialization
	void Start () {

		// Get the animator controller of the player
		m_animator = GetComponent<Animator> ();
		//m_animator.SetTrigger ("WalkBegin");

	}
	
	// Update is called once per frame
	void Update () {

		// check if the user ask for walk
		if (Input.GetAxis ("Horizontal") > 0) { 
			m_animator.SetBool("IsWalking", true);
		} else {
			m_animator.SetBool("IsWalking", false);
		}

		// check if the user ask for back
		if (Input.GetAxis ("Horizontal") < 0) { 
			m_animator.SetBool("IsBacking", true);
		} else {
			m_animator.SetBool("IsBacking", false);
		}

		// Punch!
		if (Input.GetButtonDown ("Fire1")) {
			m_animator.SetTrigger("Punch");
		}

	}
}
