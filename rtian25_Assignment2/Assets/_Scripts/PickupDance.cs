using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDance : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 50, Space.World);
        float posY = Mathf.Sin(Time.time * 1.5f);
        transform.position = new Vector3(transform.position.x, posY * 0.5f + 1.5f, transform.position.z);
    }
}
