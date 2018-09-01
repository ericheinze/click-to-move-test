using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float mUp;
    public float mDown;
    public float mLeft;
    public float mRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, mUp * Time.deltaTime);
        transform.Rotate(Vector3.down, mDown * Time.deltaTime);
        transform.Rotate(Vector3.left, mLeft * Time.deltaTime);
        transform.Rotate(Vector3.right, mRight * Time.deltaTime);
    }
}
