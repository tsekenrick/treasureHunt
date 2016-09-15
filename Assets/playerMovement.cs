using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 10f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -10f * Time.deltaTime) ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -60f * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 60f * Time.deltaTime, 0);
        }

        Camera.main.transform.position = transform.position + new Vector3(0, 8f, -5f);
    }
}
