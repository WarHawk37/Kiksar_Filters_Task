using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private DeviceCamController deviceCam;
    public GameObject item;
    public Transform itemSpwan;

    // Start is called before the first frame update
    void Start()
    {
        deviceCam = FindObjectOfType<DeviceCamController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnApply_Button_Click()
    {
     GameObject obj =   Instantiate(item, itemSpwan.position, itemSpwan.rotation);
        obj.transform.SetParent(deviceCam.transform);
        


    }


}
