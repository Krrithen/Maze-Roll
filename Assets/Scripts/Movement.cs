using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;
	public Vector3 vector ;
	public Vector3 vector100 ;
	public Vector3 vector200 ;
	public Vector3 vector300 ;

	public Vector3 vector400 ;
	public Vector3 vector500 ;
	public Vector3 vector700 ;
	public Vector3 vector900 ;
	public Vector3 vector1100 ;
	public Vector3 vector1300 ;

	

	// Use this for initialization
	void Start () {

		Screen.sleepTimeout=SleepTimeout.NeverSleep;

		rb.GetComponent<Rigidbody>();
		vector = new Vector3(0,0,12);
		vector100 = new Vector3(0,0,15);
		vector200 = new Vector3(0,0,20);
		vector300 = new Vector3(0,0,25);
		vector400 = new Vector3(0,0,29);
		vector500 = new Vector3(0,0,33);
		vector700 = new Vector3(0,0,37);
		vector900 = new Vector3(0,0,41);
		vector1100 = new Vector3(0,0,45);
		vector1300 = new Vector3(0,0,50);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(rb.position.z>-1 && rb.position.z<=100){
			rb.velocity=vector;
		//	rb.AddForce(0,0,20);
		}if(rb.position.z>100 && rb.position.z<=200){
			rb.velocity=vector100;
		//	rb.AddForce(0,0,30);
		}if(rb.position.z>200 && rb.position.z<=300){
			rb.velocity=vector200;
		//	rb.AddForce(0,0,30);
		}if(rb.position.z>300 && rb.position.z<=400){
			rb.velocity=vector300;
		//	rb.AddForce(0,0,30);
		}if(rb.position.z>400 && rb.position.z<=500){
			rb.velocity=vector400;
		//	rb.AddForce(0,0,30);
		}if(rb.position.z>500 && rb.position.z<=700){
			rb.velocity=vector500;
		//	rb.AddForce(0,0,30);
		}if(rb.position.z>700 && rb.position.z<=900){
			rb.velocity=vector700;
		}if(rb.position.z>900 && rb.position.z<=1100){
			rb.velocity=vector900;
		}if(rb.position.z>1100 && rb.position.z<=1300){
			rb.velocity=vector1100;
		}if(rb.position.z>1300){
			rb.velocity=vector1300;
		}

		

		transform.Translate(Input.acceleration.x,0,0);

		if(rb.position.y<-1f){
				FindObjectOfType<GameManager>().endgame();
}

	}


}
