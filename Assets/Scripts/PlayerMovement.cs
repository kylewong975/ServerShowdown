using UnityEngine;
using System.Collections;

/*
The PlayerMovement script regulates the player character's movement.
*/
public class PlayerMovement : MonoBehaviour {

    public float JumpSpeed = 100.0f;    //speed of the jump
    public Rigidbody rb;                //Rigidbody of the player
    bool repeatAnim;                    //Determines if the animation should be replayed

    /*
    The start function initializes the repeatAnim variable to true, allowing animation to be replayed.
    */
    void Start()
    {
        repeatAnim = true;
    }

	/*
	The FixedUpdate function determines a rotation and forward/backward movement
	based on the horizontal and vertical inputs.
	It animates the player character accordingly, by whether it is moving or is
	idle/rotating.

    When the player presses the left control button or clicks the left mouse button, the shooting animation
    is played. However, if the player holds down the button, the shooting animation stops and will not be replayed
    until the player releases the button.

    When the player presses the space button, the character will jump at a speed defined in JumpSpeed,
    taking into account gravity. To prevent spamming the space bar to repeatedly project
    the player upwards, a velocity threshold is placed so that only one jump can be performed in the air.
	*/
	void FixedUpdate() {
		float horizontal = Input.GetAxis("Horizontal") * 2.0f;
		transform.Rotate(new Vector3(0, horizontal, 0));

		if (horizontal == 0)
		{
			transform.Rotate (new Vector3(0,0,0));
		}
		
		float vertical = Input.GetAxis ("Vertical") * 0.5f;
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection (new Vector3 (-vertical, 0, 0)));

		if (!GetComponent<Animation>().IsPlaying("punch_hi_left")){
			if (vertical!=0)
			{

				GetComponent<Animation>().Play ("loop_run_funny");
				GetComponent<Animation>()["loop_run_funny"].speed = 2.0f;

			}
			else
			{
				GetComponent<Animation>().Play ("loop_idle");
			}
		
			if (Input.GetAxisRaw ("Fire1") == 1) 
			{
				if(repeatAnim)
                {
                    GetComponent<Animation>().Play("punch_hi_left");
                    GetComponent<Animation>()["punch_hi_left"].speed = 2.2f;
                    repeatAnim = false;
                }
			}
            if(Input.GetMouseButtonUp(0) || Input.GetAxis("Fire1")==0)
            {
                repeatAnim = true;
            }
	
		}

        if(Input.GetKeyDown("space"))
        {
            if(rb.velocity.y < 0.2 && rb.velocity.y > -0.2)
            {
                float a = Time.deltaTime;
                GetComponent<Animation>().Play("jump");
                rb.velocity = new Vector2(0, Mathf.Pow((-2.0f * Physics.gravity.y * a * JumpSpeed), 0.6f));
            }
        }
	}
}