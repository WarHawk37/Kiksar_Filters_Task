using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class DeviceCamController : MonoBehaviour
{

    public GameObject webPlane;
    public GameObject[] filters;
    private WebCamDevice[] webcamDevices;
    private WebCamTexture camTexture;

    // Start is called before the first frame update
    void Start()
    {
   
        webcamDevices = WebCamTexture.devices;
        camTexture = new WebCamTexture(webcamDevices[0].name ,Screen.width , Screen.height , 30);
        Input.gyro.enabled = true;
        webPlane.GetComponent<MeshRenderer>().material.mainTexture = camTexture;
     camTexture.Play();
        

    }

    // Update is called once per frame
    void Update()
    {
  

        Quaternion rot = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = rot;
    }
}
