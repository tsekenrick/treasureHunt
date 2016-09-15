using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hint2 : MonoBehaviour {
    public Text hint;
    public GameObject player;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if ((transform.position - player.transform.position).magnitude < 8f)
        {
            hint.text = "You are at the capsule.\n Head south until you reach the cube.";
        } else
        {
            hint.text = "";
        }
    }
}
