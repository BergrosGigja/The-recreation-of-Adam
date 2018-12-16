using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCredit : MonoBehaviour {
    UIController _UIController;
    // Use this for initialization
    void Start () {
        _UIController = FindObjectOfType<UIController>();
     
    }
	
    void OnZoomDone()
    {
        _UIController.FadeToLevel(8);
    }
}
