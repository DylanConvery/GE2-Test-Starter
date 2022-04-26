using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    private Vector3 scaleChange;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(2, 10);
        scaleChange = new Vector3(0.1f, 0.1f, 0f);

        for (var i = 0; i < length; i++)
        {
            GameObject segment = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            segment.transform.parent = this.transform;

            segment.transform.position =transform.position - (transform.forward * i);
            segment.transform.rotation = transform.rotation;
            segment.transform.localScale -= scaleChange;

            segment.GetComponent<Renderer>().material = material;
            segment.GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);

            scaleChange -= new Vector3(0.1f, 0.1f, 0);
        }

        GameObject lead = this.transform.GetChild(0).gameObject;
        lead.AddComponent<Boid>();
        lead.AddComponent<NoiseWander>();
        lead.AddComponent<ObstacleAvoidance>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
