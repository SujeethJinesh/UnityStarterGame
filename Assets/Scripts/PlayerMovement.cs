using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rigidBody;

	// Update is called once per frame
	void FixedUpdate () //whenever you do physics, do it here and NEVER in Update
	{
        //Time.deltaTime = evens out advantage of gaming on a better comp
        rigidBody.AddForce (0, 0, 2000 * Time.deltaTime);
	}
}
