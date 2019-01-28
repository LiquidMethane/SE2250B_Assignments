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
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
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

