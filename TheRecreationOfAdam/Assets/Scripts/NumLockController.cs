using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumLockController : MonoBehaviour {

    List<int> list;
    int index;
    public TextMeshProUGUI score;
    public int correctNum;

    // Use this for initialization
    void Start () {
        list = new List<int>
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };
        index = list[1];
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickButton()
    {
        CheckIfCorrectNum(correctNum);
        if (index == 10)
        {
            index = 0;
        }
        int printNum = list[index];
        score.text = printNum.ToString();
        index++;
    }

    public void CheckIfCorrectNum(int correctNum)
    {
        if (index == correctNum)
        {
            score.color = Color.green;
        }
        else{
            score.color = Color.white;
        }
    }
}
