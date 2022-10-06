using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Prefabs;
    public int prefabs;

    void Start()
    {
        for(int i = 0; i < prefabs; i++)
        {
            var position = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), Random.Range(-10, 10));
            Instantiate(Prefabs, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
