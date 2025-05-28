using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyder : MonoBehaviour
{
   [SerializeField] GameObject skud;
    IEnumerator shooty(){
        for(int i = 0; i > -1f; i++)
        {

           if (i % 10 == 0)
           {              
                //Debug.Log("skud bliver lavet");
                GameObject duplicate = Instantiate(skud,new Vector3(transform.position.x,transform.position.y,transform.position.z + 0.1f),Quaternion.identity);
           }


                yield return new WaitForSeconds(0.1f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shooty());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
