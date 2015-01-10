#pragma strict

var bullet : Rigidbody2D;
var speed = 20;

function Start () {

}

function Update () {
	
	if (Input.GetKeyDown(KeyCode.G)) {
		createNewBullet();
	}
	
}

function createNewBullet() {
	var bulletStartPoint = transform.position;
	bulletStartPoint.x = bulletStartPoint.x + transform.localScale.x * 4.5;
	bulletStartPoint.y = bulletStartPoint.y + 0.2;
	var clone = Instantiate(bullet, bulletStartPoint, transform.rotation);
	clone.velocity = transform.TransformDirection( Vector3( speed, 0, 0 ) );
	Destroy( clone.gameObject, 3);
}