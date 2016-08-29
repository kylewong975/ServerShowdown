using UnityEngine;

/*
The PacketManager script regulates the spawning of the data packet objects during gameplay.
*/
public class PacketManager : MonoBehaviour
{

	public GameObject datapacket;	//The prefab to spawn
	public float spawnTime = 1f;	//The time interval between spawns
	public Transform spawnPoint;	//The transform (location) where the virus will spawn
	
	/*
	On instantiation, the script calls the Spawn function to spawn the packet objects
	at the spawn point at an interval defined by spawnTime;
	*/
	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	/*
	The Spawn function spawns the data packet object at the spawnPoint
	*/
	void Spawn ()
	{
		Instantiate (datapacket, spawnPoint.position, spawnPoint.rotation);
	}
}
