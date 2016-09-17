using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class intro : MonoBehaviour {
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
            hint.text = "You and your crew are lost at sea! Follow the landmarks to find land!";
        }
        else
        {
            hint.text = "";
        }
    }
}
