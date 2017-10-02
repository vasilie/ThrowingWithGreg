using UnityEngine;
using System.Collections;
public class Greg : MonoBehaviour {
	Animator anim;

	[SerializeField]
	private GameObject throwObjectPrefab;
	public GameObject weapon;

	
	
	
	[SerializeField]
	private float energy;
	
	[SerializeField]
	private Vector3 eulerAngles;
	// code --------------------------------

	void SpawnProjectile(){
	}

	// = ---------------------------------------------
		
	// Use this for initialization
	void Start () { 
		anim = GetComponentInChildren<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")){
			
			
			ThrowObject();
			//gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2((float)System.Math.Round(1f * angularResistance), 0f );
			//moveCounter+=gameObject.rigidbody2D.velocity.x*0.6f;
		}
		if (Input.GetKeyUp("space")){
			anim.SetBool("Throw", false);
			
			
			//gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2((float)System.Math.Round(1f * angularResistance), 0f );
			//moveCounter+=gameObject.rigidbody2D.velocity.x*0.6f;
		}
		
	}

	void ThrowObject(){
		anim.SetBool("Throw", true);
		weapon = (GameObject) Instantiate(throwObjectPrefab, transform.position + new Vector3(3f,1f,0f), Quaternion.Euler(eulerAngles)) as GameObject;
		
		//weapon.rigidbody2D.velocity += new Vector2(fireVelocity,0f);
		Vector3 force = new Vector3(energy * 100f, 0f, 0f);
		Vector3 newForce = Quaternion.Euler(eulerAngles) * force;
		
		weapon.GetComponent<Rigidbody2D>().AddForce(newForce);
		
		
		
	}
}
