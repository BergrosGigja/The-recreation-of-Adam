using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHover : MonoBehaviour {
	public GameObject sign;

	public void OnMouseOver()
	{
		sign.SetActive(true);
	}

	public void OnMouseExit()
	{
		sign.SetActive(false);
	}
}
