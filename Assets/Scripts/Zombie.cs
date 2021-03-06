﻿using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	private Animator anim;
	public AudioClip dieClip;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	// Start death animation
	void Die () {
		anim.SetBool ("death", true);
		audio.PlayOneShot (dieClip);
		Destroy (this.gameObject, 0.4f);
	}

}
