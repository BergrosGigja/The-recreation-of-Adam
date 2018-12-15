using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {

	// Use this for initialization
	public DialogEntry dialog;
	public void TriggerDialog()
	{
		FindObjectOfType<EntryDialogManager>().StartDialog(dialog);
	}
}
