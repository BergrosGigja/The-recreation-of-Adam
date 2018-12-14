using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    Color m_MouseOverColor = Color.white;
    Color m_OriginalColor;
    public GameObject ObjectToAppear;
    UIController _UIController;
    BoxCollider2D m_boxCollider;
    public bool DeleteItemOnClick;
    bool KeyClicked;
    GameObject DrawerText;
    public Collider2D[] clickableObjects;
    // Use this for initialization
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_OriginalColor = m_SpriteRenderer.color;
        _UIController = FindObjectOfType<UIController>();
        m_boxCollider = GetComponent<BoxCollider2D>();
        KeyClicked = false;
    }

    private void Awake()
    {
        DrawerText = GameObject.FindGameObjectWithTag("UIText");
        if (DrawerText)
        {
            DrawerText.SetActive(false);
        }

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
                if (ObjectToAppear != null)
                {
                    if (DeleteItemOnClick)
                    {
                        Destroy(gameObject);
                    }
                    Debug.Log("DO I go here?");
                    _UIController.OnHoverObjectClicked(ObjectToAppear);
                }

                if (hit.collider != null && hit.collider.tag == "FadeToLvl")
                {
                    _UIController.FadeToLevel(int.Parse(hit.collider.name));
                }
                else if (hit.collider != null && hit.collider.tag == "Key")
                {
                    SetKey();
                    Debug.Log("KeyClicked in Key = " + KeyClicked);
                }
                /*else if (hit.collider != null && hit.collider.tag == "Drawer")
                {
                    Debug.Log("KeyClicked in Drawer = " + KeyClicked);
                    if (KeyClicked == false)
                    {
                        Debug.Log("drawer text: " + DrawerText.name);
                        _UIController.NoKeyText(DrawerText);
                    }
                    else if (KeyClicked == true && ObjectToAppear != null)
                    {
                        _UIController.OnHoverObjectClicked(ObjectToAppear);
                    }
                }*/
            }
        }
    }

    void SetKey()
    {
        KeyClicked = true;
    }

    public bool GetKey()
    {
        return KeyClicked;
    }

    void OnMouseOver()
    {
        m_SpriteRenderer.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        m_SpriteRenderer.color = m_OriginalColor;
    }
}