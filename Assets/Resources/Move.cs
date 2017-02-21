using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float zSpeed = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position +=  new Vector3(xSpeed, ySpeed, zSpeed) * Time.deltaTime;
    }
}
