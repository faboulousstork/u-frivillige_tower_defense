using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using System.Numerics;

public class Spawn_frivilligt : MonoBehaviour
{
    public int ilive = 0;
    public UnityEngine.Vector3 spawn;
    public int wave = 1;

    //public GameObject trekant;
    void Start()
    {
        spawn = new UnityEngine.Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int wawe = 0;
    void FixedUpdate()
    {
        wawe += 1;
        if (Input.GetKey(KeyCode.Space) && wawe % 119 == 0)
        {
            wave += 1;
            Debug.Log("rasmus er noob");
            for (int i = 0; i < wave; i++)
            {
                Instantiate(new GameObject("trekant"), spawn, new UnityEngine.Quaternion(0, 0, 0, 0));
            }
        }

    }
}

