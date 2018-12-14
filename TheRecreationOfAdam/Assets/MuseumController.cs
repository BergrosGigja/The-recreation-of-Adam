using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumController : MonoBehaviour {

    public GameObject[] clickableObjects;
    public GameObject[] objectsToAppear;
    UIController _UIController;
    // Use this for initialization
    void Start () {
        _UIController = FindObjectOfType<UIController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            foreach (var obj in clickableObjects)
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name)
                    {
                        case "color_box":
                            //newspaper appears
                            objectsToAppear[0].SetActive(true);
                            break;
                        case "basement_door":
                            //newspaper appears
                            _UIController.FadeToLevel(5);
                            break;
                    }
                }
            }
        }
    }
}
