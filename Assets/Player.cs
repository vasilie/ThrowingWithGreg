using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour {
	Animator anim;
	public float maxSpeed;
	public float resistance;
	private float angularResistance = 1f;
	// Use this for initialization
	void Start () { 
		anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey("right") || Input.GetKey("left") && Input.GetKey("up") || Input.GetKey("down")) {
			angularResistance = 0.53f;
		} else {
			angularResistance = 1f;
		}
//		
		if (Input.GetKeyDown("space")){
			anim.SetBool("Throw", true);
			
			
		
			//gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2((float)System.Math.Round(1f * angularResistance), 0f );
			//moveCounter+=gameObject.rigidbody2D.velocity.x*0.6f;
		}
		if (Input.GetKeyUp("space")){
			anim.SetBool("Throw", false);
			
			
			//gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2((float)System.Math.Round(1f * angularResistance), 0f );
			//moveCounter+=gameObject.rigidbody2D.velocity.x*0.6f;
		}
		
	}
}
