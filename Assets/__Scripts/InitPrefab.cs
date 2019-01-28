using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPrefab : MonoBehaviour
{
    public GameObject prefabVar;
    public int height;
    private GameObject prefab;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(-8, height, -8);
        for (int i = 0; i < 64; i++)
        {
            pos = new Vector3(-8, height + i, -8);
            for (int j = 0; j < 16; j++)
            {
                pos = new Vector3(-8 + j, height + i, -8);
                for (int k = 0; k < 16; k++)
                {
                    prefab = Instantiate(prefabVar);
                    prefab.transform.position = pos + new Vector3(0, 0, k);
                    prefab.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                }

            }
        }
    }
}
