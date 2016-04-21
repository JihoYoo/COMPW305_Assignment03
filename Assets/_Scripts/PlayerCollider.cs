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

public class PlayerCollider : MonoBehaviour {
    private AudioSource[] _audioSources;

    public GameController gameController;
    private AudioSource _damageSound;

	// Use this for initialization
	void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();

        this._damageSound = this._audioSources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            this._damageSound.Play ();
            this.gameController.LivesValue -= 1;
            



        }
     
    }
}
