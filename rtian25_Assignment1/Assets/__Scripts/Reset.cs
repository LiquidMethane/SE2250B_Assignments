using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Rigidbody rb;
    Vector3 originalPos;
    Quaternion originalRot;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = gameObject.transform.position;
        originalRot = gameObject.transform.rotation;
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

}

