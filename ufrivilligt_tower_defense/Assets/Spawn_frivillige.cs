using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class Spawn_frivilligt : MonoBehaviour
{
    public int ilive = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    public int wawe = 0;
    void FixedUpdate()
    {
        wawe += 1; 
        if (Input.GetKey(KeyCode.Space) && wawe % 119 == 0)
        {
            Debug.Log("rasmus er noob");
        }
    }
}
