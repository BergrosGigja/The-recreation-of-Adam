﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorAppear : MonoBehaviour {

    public Color blobColor;
    Collider2D[] objInsideZone;
    Collider2D[] objOutsideZone;
    public GameObject player;
    public Collider2D[] objInScene;

    private void FixedUpdate()
    {
        objInsideZone = Physics2D.OverlapCircleAll(player.transform.position, 5f);
        for (var i = 0; i < objInsideZone.Length; i++)
        {
            if (objInsideZone[i].tag == "ChangeColor")
            {
                SpriteRenderer sprite = objInsideZone[i].GetComponent<SpriteRenderer>();
                sprite.color = blobColor;
            }
        }
        objOutsideZone = objInScene.Except(objInsideZone).ToArray();

        for(var i = 0; i < objOutsideZone.Length; i++)
        {
            if (objOutsideZone[i].tag == "ChangeColor")
            {
                SpriteRenderer sprite = objOutsideZone[i].GetComponent<SpriteRenderer>();
                sprite.color = Color.white;
            }
        }
    }
}