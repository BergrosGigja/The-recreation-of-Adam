using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryController : MonoBehaviour {

    public GameObject[] clickableObjects;
    public GameObject[] objectsToAppear;
    UIController _UIController;
    int m_layer_mask;
    // Use this for initialization
    void Start () {
        _UIController = FindObjectOfType<UIController>();
        m_layer_mask = LayerMask.GetMask("Interactive");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero, 10f, m_layer_mask);
             
            foreach (var obj in clickableObjects)
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name)
                    {
                        case "NewspaperStand":
                            //newspaper appears
                            objectsToAppear[0].SetActive(true);
                            break;
                        case "Book1":
                            //ripped order appears
                            objectsToAppear[1].SetActive(true);
                            break;
                        case "Book2":
                            //colorblind book appears
                            objectsToAppear[2].SetActive(true);
                            break;
                        case "Book3":
                            //50_shades apperas
                            objectsToAppear[4].SetActive(true);
                            break;
                        case "50_shades":
                            //50_shades_open appears after 50_shades gets destroyed
                            Destroy(clickableObjects[6]);
                            objectsToAppear[5].SetActive(true);
                            break;
                        case "colorblind_book":
                            //open book appears after colorblind_book is destroyed
                            Destroy(clickableObjects[3]);
                            objectsToAppear[2].SetActive(true);
                            break;
                        case "lockedBox":
                            //closeup_box appears
                            objectsToAppear[6].SetActive(true);
                            break;
                        case "exit_door":
                            //closeup_box appears
                            _UIController.FadeToLevel(6);
                            break;

                    }
                }
            }
        }
    }
}
