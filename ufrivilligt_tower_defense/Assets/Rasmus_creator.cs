using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasmus_creator : MonoBehaviour
{
    public Color green = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        //SpriteRenderer SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    
    void OnMouseOver() {
        Debug.Log("dint");
     if (Input.GetKeyUp(KeyCode.Mouse0)){
            Debug.Log("clickity");
            //SpriteRenderer.color = green;
        }
        }
        }

