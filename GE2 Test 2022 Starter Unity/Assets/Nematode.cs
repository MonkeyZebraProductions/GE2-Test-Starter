using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public float length = 5;

    public Material material;

    private Vector3 SphereScale=Vector3.one;

    void Awake()
    {
        // Put your code here!

        float privLenghth = Random.Range(1, length);
        for (int i=0;i< privLenghth; i++)
        {
            float colour = (1f / privLenghth) * i;

            GameObject sphere= GameObject.CreatePrimitive(PrimitiveType.Sphere);
            MeshRenderer meshRenderer = sphere.GetComponent<MeshRenderer>();
            sphere.transform.position = new Vector3(0f, 0f, i);
            meshRenderer.material.color = Color.HSVToRGB(colour, 1, 1);
            if (i <= Mathf.Ceil(privLenghth / 2))
            {
                SphereScale += new Vector3(0.1f, 0, 0);
            }
            else
            {
                SphereScale -= new Vector3(0.1f, 0, 0);
            }
            sphere.transform.localScale = SphereScale;
            sphere.transform.SetParent(transform);
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
