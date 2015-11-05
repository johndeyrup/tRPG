using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public int player_speed =1;
	// Use this for initialization
	void Start () {

	}
	
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {

    }
}
