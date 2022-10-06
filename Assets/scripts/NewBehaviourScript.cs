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
            var position = new Vector3(Random.Range(-30, 30), Random.Range(5, 10), Random.Range(-30, 30));
            Instantiate(Prefabs, position, Quaternion.identity);
        }
    }
}
