/* 
 * 	the Source file name: COMP305_Assignment03
 * 	Author’s name: Jiho Yoo
 * 	Last Modified by: Jiho Yoo
 * 	Date last Modified: March 25, 2016
 * 	Program	description: The player kills enemies and gets scores by hit the barrels
 * 	Revision History: March 17 - started making game
 * 	                  March 18 - added assets
 * 	                  March 19 - added images
 * 	                  March 21 - added zombies
 * 	                  March 22 - added sound
 * 	                  March 24 - added labels
 * 	                  March 25 - find errors and upload file
 */
using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	//PRIVATE INSTANCE VARIABLES
	private Transform _player; // Reference to the player's position.
	private PlayerController _playerHealth; // Reference to the player's health.
	private NavMeshAgent _nav;// Reference to the nav mesh agent.
	//	public float speed;
	
	void Awake ()
	{
		// Set up the references.
		_player = GameObject.FindGameObjectWithTag ("Player").transform;
		_playerHealth = _player.GetComponent <PlayerController> ();
		_nav = GetComponent <NavMeshAgent> (); 
	}
	
	void Update ()
	{
		

			_nav.SetDestination (_player.position); //moves toward the player

	} 
}