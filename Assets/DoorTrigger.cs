using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorTrigger : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") 
		{
		anim.SetTrigger("open"); 
		}
			
	}

	void OnTriggerExit (Collider other) {
		if(other.tag=="Player")
			anim.SetTrigger("close");
	}
}
