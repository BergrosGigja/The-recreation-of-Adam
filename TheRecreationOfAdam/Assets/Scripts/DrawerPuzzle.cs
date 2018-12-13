using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerPuzzle : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    BoxCollider2D m_boxCollider;
    OnHover _OnHover;
    bool keyClicked;
    // Use this for initialization
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_boxCollider = GetComponent<BoxCollider2D>();
        _OnHover = FindObjectOfType<OnHover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null && hit.collider == m_boxCollider)
            {
                keyClicked = _OnHover.GetKey();
                Debug.Log("In drawerScript key is: " + keyClicked);
            }
        }
    }
    void OnMouseOver()
    {
        m_SpriteRenderer.color = Color.white;
    }

    void OnMouseExit()
    {
        m_SpriteRenderer.color = Color.black;
    }
}