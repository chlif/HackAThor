#pragma strict

var bullet : Rigidbody2D;
var clip: AudioClip;
var speed = 10;

function Start () {

}

function Update () {
	
	if (Input.GetKeyDown(KeyCode.G)) {
		createNewBullet();
	}
	
}

function createNewBullet() {
	var direction = transform.parent.localScale.x;
	var bulletStartPoint = transform.position;
	bulletStartPoint.x = bulletStartPoint.x + direction * 1.5;
	bulletStartPoint.y = bulletStartPoint.y + 0.2;
	
	var clone = Instantiate(bullet, bulletStartPoint, transform.rotation);
	clone.velocity = transform.TransformDirection( Vector3( direction * speed, 0, 0 ) );

	audio.PlayOneShot(clip);
			
	Destroy( clone.gameObject, 3);
}