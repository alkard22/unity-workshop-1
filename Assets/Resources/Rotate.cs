using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotateSpeed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
