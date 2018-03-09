using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimState {
	IDLE = 0,
	WALK
}

public class EnemyBehaviour : MonoBehaviour {

	// reference the Enemy Animator
	public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") != 0) {
			this.animator.SetInteger ("AnimState", (int)AnimState.WALK);
		} else {
			this.animator.SetInteger ("AnimState", (int)AnimState.IDLE);
		}
	}
}
