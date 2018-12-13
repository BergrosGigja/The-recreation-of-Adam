using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjState : MonoBehaviour {

	public void SetObjActive()
    {
        gameObject.SetActive(true);
    }

    public void DisableObj()
    {
        gameObject.SetActive(false);
    }
}
