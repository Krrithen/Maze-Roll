using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical1 : MonoBehaviour {

	public Movement movement;

	void OnCollisionEnter(Collision collision){
		if(collision.collider.tag=="Obstacle"){
			movement.enabled=false;
			
			FindObjectOfType<GameManager>().endgame();
			

		}
	}
		
}
