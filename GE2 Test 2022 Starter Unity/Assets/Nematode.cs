using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    public GameObject sphere;

    private Vector3 scaleChange;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(2, 10);
        scaleChange = new Vector3(0.1f, 0.1f, 0f);

        for (var i = 0; i < length; i++)
        {
            GameObject segment = Instantiate(sphere, transform.position, transform.rotation, gameObject.transform);
            segment.transform.localScale -= scaleChange;
            scaleChange -= new Vector3(0.1f, 0.1f, 0);
            segment.transform.position = transform.position - (transform.forward * i);
        }
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
