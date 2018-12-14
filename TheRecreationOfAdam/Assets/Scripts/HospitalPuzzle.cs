using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalPuzzle : MonoBehaviour
{
    public GameObject[] clickableObjects;
    public GameObject[] objectsToAppear;
    bool m_keyClicked;
    bool m_blobFound;
    UIController _UIController;

    // Use this for initialization
    void Start()
    {
        m_keyClicked = false;
        m_blobFound = false;
        _UIController = FindObjectOfType<UIController>();
    }

    // Update is called once per frame
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
                        case "calendar_with_key":
                            //calendar_closeup appears
                            objectsToAppear[0].SetActive(true);
                            //calendar_with_key is destroyed
                            Destroy(clickableObjects[0]);
                            break;
                        case "calendar_closeup":
                            //key appears
                            objectsToAppear[1].SetActive(true);
                            //calendar_closeup is destroyed
                            Destroy(clickableObjects[1]);
                            break;
                        case "key":
                            //key_text appears
                            objectsToAppear[2].SetActive(true);
                            //key is destroyed
                            Destroy(clickableObjects[2]);
                            m_keyClicked = true;
                            break;
                        case "drawer_closed":
                            if(m_keyClicked)
                            {
                                //blob
                                objectsToAppear[3].SetActive(true);
                                m_blobFound = true;
                                //drawer is destroyed
                                Destroy(clickableObjects[3]);
                            }
                            else
                            {
                                //locked text appears
                                objectsToAppear[4].SetActive(true);
                            }

                            break;
                        case "hospital_room_chart":
                            //chart appears
                            objectsToAppear[5].SetActive(true);
                            break;
                        case "exit_door":
                            if (m_blobFound)
                            {
                                _UIController.FadeToLevel(2);
                            }
                            else{
                                //nurse ban appears
                                objectsToAppear[6].SetActive(true);
                            }
                            break;
                    }
                }
            }
        }

    }
}
