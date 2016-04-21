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

public class EnemyAttack : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float attackRate = 0.5f;
	public int attackDamage = 10;
	
	//PRIVATE INSTANCE VARIABLES 
	private GameObject _player;
	private PlayerController _playerHealth;
	private bool _playerInRange;
	private float _timer;
	
	//SET UP
	void Awake ()
	{
		_player = GameObject.FindGameObjectWithTag ("Player"); 
		_playerHealth = _player.GetComponent <PlayerController> ();//script reference
	}
	
	//TRIGGER METHODS
	//Ensuring player is near, if yes then attack
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == _player)
		{
			_playerInRange = true;//player's near
		}
	}
	
	//If player is gone, then stop attacking
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == _player)
		{
			_playerInRange = false; 
		}
	}
	
	//
	void Update ()
	{
		_timer += Time.deltaTime;
		
		//note (in parameters): if(time to attack AND player's in range then attack!
		if(_timer >= attackRate && _playerInRange) // && _enemyHealth.currentHealth > 0
		{
			Attack ();
		}
		

	}
	
	//Actual attack function
	void Attack ()
	{
		_timer = 0f;
		
		if(_playerHealth.currentHealth > 0)
		{
			_playerHealth.TakeDamage (attackDamage);
		}
	}
}