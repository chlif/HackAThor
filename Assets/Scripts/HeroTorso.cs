using UnityEngine;
using System.Collections;

public class HeroTorso : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 parentVelocity = transform.parent.rigidbody2D.velocity;
		float xVelocity = parentVelocity.x;

		anim.SetFloat ("speed", xVelocity);
	}
}
