using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_game : MonoBehaviour
{
    public GameObject Prefabs;

    void Start()
    {   
        for(int i = 0; i<10; i++)
        {   
            //Random.Range lo que hace es que el prefabs aparezca dentro del rango que hemos dado en los ejes XYZ.
            var position = new Vector3(Random.Range(-30, 30), Random.Range(5, 10), Random.Range(-30, 30));
            Instantiate(Prefabs, position, Quaternion.identity);
        }
    }
}
