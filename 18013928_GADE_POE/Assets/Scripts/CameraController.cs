using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float CameraSpeed = 10f;
    public float Zoom;
    private Vector2 movement = new Vector3();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            transform.position += new Vector3(-1, 1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
            transform.position += new Vector3(-1, -1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("w") && Input.GetKey("d"))
        {
            transform.position += new Vector3(1, 1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
            transform.position += new Vector3(1, -1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -1) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-1, 0) * CameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1,0) * CameraSpeed * Time.deltaTime;
        }
        else
        {

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
        {

            Camera.main.orthographicSize += 10 * Time.deltaTime; 

        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
        {
            Camera.main.orthographicSize -= 10 * Time.deltaTime;
        }

    }
}
