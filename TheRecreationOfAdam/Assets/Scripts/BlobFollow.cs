using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobFollow : MonoBehaviour {

    public GameObject target;
    public float y_axis;
    Vector2 targetPos;
    Vector2 blobPos;
    bool right;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        blobPos = transform.position;
        right = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = target.transform.position;
        if(right)
        {
            blobPos = new Vector2(targetPos.x - 1.5f, y_axis);
        }
        else
        {
            blobPos = new Vector2(targetPos.x + 1.5f, y_axis);
        }

        if ((blobPos.x >= transform.position.x))
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
            right = false;
        }
        else
        {
            transform.localScale = new Vector2(-1.0f, 1.0f);
            right = true;
        }
        if (Vector2.Distance(blobPos, transform.position) > 0.2)
        {
            anim.SetBool("Walking", true);
            transform.position = Vector2.MoveTowards(transform.position, blobPos, 2.5f * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

    }
}
