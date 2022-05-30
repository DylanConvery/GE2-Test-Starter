using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range(1, 5000)]
    public int radius = 50;
    public int count = 10;

    void Awake()
    {
        // Put your code here
        for (int i = 0; i < count; i++)
        {
            GameObject nematode = Instantiate(prefab, Random.insideUnitSphere * radius, Quaternion.identity);
            nematode.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        }
    }
}
