using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonManager : MonoBehaviour
{
    public string parentObjName;
   
    private DeviceCamController deviceCam;

   
   
    // Start is called before the first frame update
    void Start()
    {
        parentObjName = this.gameObject.transform.parent.gameObject.name;
        deviceCam = FindObjectOfType<DeviceCamController>();

    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  OnResetButton_Click()
    {

        switch (parentObjName)
        {

            case "Cloth":
                deviceCam.filters[0].SetActive(true);
                
                break;
            case "Watch":
                deviceCam.filters[1].SetActive(true);
                Destroy(this.gameObject);
                break;
            default:
                break;
        }

        
    }
}
