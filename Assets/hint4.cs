using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hint4 : MonoBehaviour {
    public Text hint;
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - player.transform.position).magnitude < 8f)
        {
            hint.text = "You are at the tower.\n Head north until you reach your salvation.";
        }
        else
        {
            hint.text = "";
        }
    }
}
