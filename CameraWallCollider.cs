using UnityEngine;
using System.Collections;

/*
The CameraWallCollider class allows the player to see the Player when the Player is backed against
a wall. The Wall is made transparent to achieve this.
*/
public class CameraWallCollider : MonoBehaviour
{
    /*
	The OnTriggerEnter function makes the wall transparent.
	*/
    void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("UI/Unlit/Transparent");
    }

    /*
	The OnTriggerExit function makes the wall opaque again.
	*/
    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
    }
}
