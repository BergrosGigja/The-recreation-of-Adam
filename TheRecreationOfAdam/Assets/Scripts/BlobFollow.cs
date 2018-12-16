using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobFollow : MonoBehaviour {

    public GameObject target;
    public float y_axis;
    public Vector2 scale;
    public float blobSpeed;
    Vector2 targetPos;
    public float x_axis;
    Vector2 blobPos;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        blobPos = transform.position;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        scale = target.gameObject.GetComponent<Transform>().localScale;
        targetPos = target.transform.position;

        if(scale.x == -1) 
        {
            x_axis = targetPos.x - 1.5f;
        } else 
        {
            x_axis = targetPos.x + 1.5f;
        }

        blobPos = new Vector2(x_axis, y_axis);
        if ((blobPos.x >= transform.position.x))
        {
            transform.localScale = scale;
        }
        else
        {
            transform.localScale = scale;
        }

        if (Vector2.Distance(blobPos, transform.position) > 0.2)
        {
            anim.SetBool("Walking", true);
            transform.position = Vector2.MoveTowards(transform.position, blobPos, blobSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Wall") {
            anim.SetBool("Walking", false);
            blobPos = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
