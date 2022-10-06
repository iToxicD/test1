using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Prefabs;

    void Start()
    {
        for(int i = 0; i<10; i++)
        {
            var position = new Vector3(Random.Range(-20, 20), Random.Range(-5, 5), Random.Range(-10, 10));
            Instantiate(Prefabs, position, Quaternion.identity);
        }
    }
}
