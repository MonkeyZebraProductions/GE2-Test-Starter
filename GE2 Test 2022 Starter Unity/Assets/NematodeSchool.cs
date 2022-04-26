using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    public float minY, maxY;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i=0; i <=count; i++)
        {
            Vector3 randompos = new Vector3(Random.insideUnitSphere.x * radius, transform.position.y, Random.insideUnitSphere.z * radius);
            Instantiate(prefab, randompos, Quaternion.Euler(0, Random.Range(minY, maxY), 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
