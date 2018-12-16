using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScrews : MonoBehaviour
{

    bool screw1;
    bool screw2;
    bool screw3;
    bool screw4;
    public GameObject closeUpBox;
    public GameObject wholeBox;
    public GameObject orangeBlob;
    public GameObject button;

    // Use this for initialization
    void Start()
    {
        screw1 = false;
        screw2 = false;
        screw3 = false;
        screw4 = false;
    }

    public void Screw1Loose()
    {
        screw1 = true;
        CheckAllScrews();
    }

    public void Screw2Loose()
    {
        screw2 = true;
        CheckAllScrews();
    }

    public void Screw3Loose()
    {
        screw3 = true;
        CheckAllScrews();
    }

    public void Screw4Loose()
    {
        screw4 = true;
        CheckAllScrews();
    }

    void CheckAllScrews()
    {
        if(screw1 && screw2 && screw3 && screw4)
        {
            var blobScript = orangeBlob.GetComponent<BlobFollow>();
            Destroy(closeUpBox);
            Destroy(wholeBox);
            blobScript.SetSpeed(2.1f);
            orangeBlob.SetActive(true);
            button.SetActive(true);
        }
    }
}



