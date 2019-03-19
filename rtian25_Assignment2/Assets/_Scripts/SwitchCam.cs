using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera mainCamera;
    public Camera followCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = false;
        followCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            followCamera.enabled = !followCamera.enabled;
        }
    }

}
