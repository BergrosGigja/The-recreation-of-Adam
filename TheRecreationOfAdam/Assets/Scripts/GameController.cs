using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject AdamPrefab;

    float _startPositionX = 5;
    float _startPositionY = 3;

    // Use this for initialization
    void Awake()
    {
        GameObject Adam = (GameObject)Instantiate(AdamPrefab);
        Adam.transform.position = new Vector2(_startPositionX, _startPositionY);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
