using UnityEngine;
using System.Collections;

/*
The ShieldManager script manages the shield health (connected to the player's health), located in the hacker connection, 
which is used in conjunction with the PacketManager and Navigation scripts for Level 6.
*/
public class ShieldManager : MonoBehaviour {

    GameObject slider;          //the player health's slider
    PlayerHealth ph;            //the PlayerHealth script reference
    public int damage;          //the amount of damage to be received

    /*
    The Start function initializes the reference to the player's health slider and sets up the damage to be received
    by the player if the data packet touches the shield.
    */
    void Start () {
        slider = GameObject.Find("PlayerHealthUI");
        ph = slider.GetComponent<PlayerHealth>();
        damage = 10;
    }

    /*
    The OnTriggerEnter function detects a collision. If the collision made hits an object with a Shield tag,
    the player takes damage and the data packet is removed.
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shield")
        {
            ph.TakeDamage(damage);
            Destroy(this.gameObject, 0f);
        }
    }
}
