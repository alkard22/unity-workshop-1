using UnityEngine;

public class Orbit : MonoBehaviour {

    public Transform objectToRotateAround;
    public float rotateSpeed = 40f;

	// Use this for initialization
	void Start () {
		
        if(!objectToRotateAround) {
            Debug.LogError(this.name + " is missing reference to objectToRotateAround");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(objectToRotateAround) {
            this.transform.RotateAround(objectToRotateAround.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
