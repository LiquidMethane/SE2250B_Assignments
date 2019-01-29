using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPrefab : MonoBehaviour
{
    public GameObject prefabVar;
    public int height;
    private GameObject prefab;
    public int cubeSize;
    private int boundary;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        boundary = cubeSize / 2;
        pos = new Vector3(-boundary, height, -boundary);
        for (int i = 0; i < cubeSize; i++)
        {
            pos = new Vector3(-boundary, height + i, -boundary);
            for (int j = 0; j < cubeSize; j++)
            {
                pos = new Vector3(-boundary + j, height + i, -boundary);
                for (int k = 0; k < cubeSize; k++)
                {
                    prefab = Instantiate(prefabVar);
                    prefab.transform.position = pos + new Vector3(0, 0, k);
                    prefab.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                }

            }
        }
    }
}
