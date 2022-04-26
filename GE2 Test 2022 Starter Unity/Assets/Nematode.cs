using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public float length = 5;

    public Material material;

    public transform StartPos;
    private Vector3 SphereScale=Vector3.one;

    void Awake()
    {
        // Put your code here!

        for(int i=0;i<=Random.Range(1,length), i++)
        {
            GameObject sphere= GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.SetPatent(transform.this)
            sphere.transform.position = StartPos.position + new Vector3(i, 0, 0);
            sphere.renderer.material.color = Color.HSVtoRGB(i, 1, 1);

            if(i <= Math Mathf.Ceil(length / 2))
            { 
               SphereScale+= new Vector3(1, 0, 0)
            }
            else
            {
                SphereScale -= new Vector3(1, 0, 0)
            }
            sphere.transform.scale = SphereScale;
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
