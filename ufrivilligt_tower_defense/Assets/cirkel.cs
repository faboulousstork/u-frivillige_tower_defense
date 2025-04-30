using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cirkel : MonoBehaviour
{
int placed = 0;
     [SerializeField] GameObject circle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0) && placed == 0) {
        GameObject duplicate = Instantiate(circle,new Vector3(transform.position.x + 0.4f,transform.position.y - 0.1f,-1f),Quaternion.identity);
        placed += 1;
        }
    }
}
