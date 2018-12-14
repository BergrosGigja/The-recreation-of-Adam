using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorAppear : MonoBehaviour {

    public Color blobColor;
    Collider2D[] objInsideZone;
    Collider2D[] objOutsideZone;
    public Collider2D[] objInScene;
    public GameObject blob;

    private void FixedUpdate()
    {
        if (blob.activeSelf == true)
        {

            objInsideZone = Physics2D.OverlapCircleAll(blob.transform.position, 5f, LayerMask.GetMask("Color Change"));
            for (var i = 0; i < objInsideZone.Length; i++)
            {
                if (objInsideZone[i].tag == "ChangeColor" && objInScene.Contains<Collider2D>(objInsideZone[i]))
                {
                    SpriteRenderer sprite = objInsideZone[i].GetComponent<SpriteRenderer>();
                    Debug.Log("blob color is: " + blobColor + " + item: " + transform.name);
                    sprite.color = blobColor;
                }
            }
            objOutsideZone = objInScene.Except(objInsideZone).ToArray();

            for (var i = 0; i < objOutsideZone.Length; i++)
            {
                if (objOutsideZone[i].tag == "ChangeColor")
                {
                    SpriteRenderer sprite = objOutsideZone[i].GetComponent<SpriteRenderer>();
                    sprite.color = Color.white;
                }
            }
        }
     }
}
