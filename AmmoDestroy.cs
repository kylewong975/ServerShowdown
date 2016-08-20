using UnityEngine;
using System.Collections;

/*
The AmmoDestroy script determines how long the ammo that is instantiated should last before it gets destroyed, to prevent
debris and unnecessary memory usage.
*/
public class AmmoDestroy : MonoBehaviour {

    public float lifetime = 4.0f;       //Defines the lifetime of the ammo as 4 seconds, before it gets destroyed.

    /*
    The Awake function is used to destroy the ammo game object in the number of seconds defined in the class
    variable "lifetime."
    */
	void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}
