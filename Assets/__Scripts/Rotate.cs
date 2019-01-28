using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    public float range;
    private bool trigger = false;
    private bool rotation = false;
    Quaternion targetRotation;
    float x, y, z;
    float rotationTime;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            trigger = true;
            x = Random.Range(-range, range);
            y = Random.Range(-range, range);
            z = Random.Range(-range, range);
            rotationTime = 0;
        }
        else
            trigger = false;
    }

    private void OnMouseExit()
    {
        trigger = false;
    }
    private void Update()
    {
        if (trigger)
        {
            x = Random.Range(-range, range);
            y = Random.Range(-range, range);
            z = Random.Range(-range, range);
            rotationTime = 0;
            rotation = true;
            targetRotation = Quaternion.Euler(x, y, z);
        }
        if (rotation)
        {
            rotationTime += Time.deltaTime * speed;
            gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, targetRotation, rotationTime);
        }

        if (rotationTime > 1)
            trigger = false;
    }
}
