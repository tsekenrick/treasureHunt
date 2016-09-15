using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameLogic : MonoBehaviour {
    public bool victory = false;
    public Text vicText;
    public GameObject player;
    public Transform treasure;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (victory)
        {
            vicText.text = "YOU GOT THE TREASURE AND YOU WIN!";
        } else if ((player.transform.position - transform.position).magnitude < 5f)
        {
            vicText.text = "Press [Space] to get treasure!";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                victory = true;
                }
        }
    }
}
