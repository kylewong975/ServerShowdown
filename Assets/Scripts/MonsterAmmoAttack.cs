using UnityEngine;
using System.Collections;

/*
The MonsterAmmoAttack script sets up the values and behaviors of the monster's laser ammo.
*/
public class MonsterAmmoAttack : MonoBehaviour {

    public int damage;                  //The damage the player receives
    public static bool isAmmoImmune;    //whether the player is immune to ammo or not
    PlayerHealth ph;                    //The PlayerHealth script reference
    GameObject slider;                  //The health slider for the player.

    /*
    The Start function intializes the basic values for the ammo. The player is not immune to the monster's laser ammo,
    and the slider's reference is initialized.
    */
    void Start()
    {
        isAmmoImmune = false;
        slider = GameObject.Find("PlayerHealthUI");
        ph = slider.GetComponent<PlayerHealth>();
    }

    /*
    The OnTriggerEnter method checks a collision col. If collision col has an "Player" tag, the laser
    ammo will deal damage to the player. Then, the monster's laser ammo is destroyed to remove clutter.
    In general, the ammo will be destroyed if it collides in an untagged object to remove clutter, but
    the player will not take damage if that happens.
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isAmmoImmune)
        {
            ph.TakeDamage(damage);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Untagged")
        {
            Destroy(this.gameObject);
        }
    }
}
