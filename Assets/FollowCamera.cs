using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	Transform camTarget;
	Transform camTrans;
	public bool cameraFollow;
	public float smoothTime = 0.01f;
	private Vector3 velocity = Vector3.zero;
	public GameObject weapon;
	private Vector3 newPosition;
	// Use this for initialization
	void Start () {
		camTrans = Camera.main.GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cameraFollow){
				MoveCamera();
		}
	}
	void MoveCamera(){
		camTarget = weapon.GetComponent<Transform>();
		newPosition = new Vector3(camTarget.position.x, camTarget.position.y,  -436.1f);
		
		
		camTrans.position = Vector3.SmoothDamp(camTrans.position, newPosition, ref velocity, smoothTime);
		
	}
}

