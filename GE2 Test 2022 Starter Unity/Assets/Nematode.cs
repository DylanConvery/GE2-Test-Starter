using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length;

    public Material material;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(10, 30);

        for (var i = 0; i < length; i++)
        {
            GameObject segment = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            segment.transform.parent = this.transform;
            segment.transform.position = transform.position - (transform.forward * i);
            segment.transform.rotation = transform.rotation;
            segment.transform.localScale = new Vector3(1 - (i / (float)length), 1 - (i / (float)length), 1);
            segment.GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);

        }

        GameObject head = this.transform.GetChild(0).gameObject;
        head.AddComponent<Boid>();
        head.AddComponent<NoiseWander>().axis = NoiseWander.Axis.Vertical;
        head.AddComponent<NoiseWander>().axis = NoiseWander.Axis.Horizontal;
        head.AddComponent<Constrain>();
        head.AddComponent<ObstacleAvoidance>();
    }
}
