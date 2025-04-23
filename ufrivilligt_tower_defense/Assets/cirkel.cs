using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cirkel : MonoBehaviour
{
    Vector3 placer = new Vector3(transform.position.x,transform.position.y,-1f);
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
        if(Input.GetKeyUp(KeyCode.Mouse0)) {
        GameObject duplicate = Instantiate(circle,placer,Quaternion.identity);
        }
    }
}
