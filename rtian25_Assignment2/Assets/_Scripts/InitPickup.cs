using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPickup : MonoBehaviour
{
    public GameObject pickupPrefab;
    private int numPickups;

    // Start is called before the first frame update
    
    void Start()
    {
        int count = 0;
        numPickups = 20;
        for (int i = 0; i < numPickups; i++)
        {
            GameObject gObj = Instantiate<GameObject>(pickupPrefab);
            gObj.name = "Pickup" + ++count;
            Vector3 pos = new Vector3(Random.Range(-13, 13), 1, Random.Range(-13, 13));
            while (!IsValidPosition(pos))
                pos = new Vector3(Random.Range(-13, 13), 1, Random.Range(-13, 13));
            gObj.transform.position = pos;
            float rand = Random.value;
            if (rand < 0.3f)
            {
                gObj.GetComponent<Renderer>().material.color = Color.blue;
                gObj.tag = "PickupBlue";
            }
                
            else if (rand < 0.7f)
            {
                gObj.GetComponent<Renderer>().material.color = Color.green;
                gObj.tag = "PickupGreen";
            }
                
            else
            {
                gObj.GetComponent<Renderer>().material.color = Color.red;
                gObj.tag = "PickupRed";
            }
                
        }
    }
    

    bool IsValidPosition(Vector3 pos)
    {
        return (pos.x > -5 && pos.x < 5 && pos.z < 5 && pos.z > -5) ? false : true;
    }
}
