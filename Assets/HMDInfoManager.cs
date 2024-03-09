using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged");
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD")
            ||XRSettings.loadedDeviceName == "MockHMD Display")
        {
            Debug.Log("Using Mock HMD ");
        }
        else
        {
            Debug.Log("We have a headset " + XRSettings.loadedDeviceName);
        }
        //Debug.Log("Is Devie Active " + XRSettings.isDeviceActive);
        //Debug.Log("Device Name : " + XRSettings.loadedDeviceName);
    }

    void Update()
    {
        
    }
}
