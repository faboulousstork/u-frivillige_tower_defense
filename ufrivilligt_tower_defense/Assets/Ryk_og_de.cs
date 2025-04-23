using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Ryk_og_de : MonoBehaviour
{

    int sofaliv = 30;
    Debug.Log()
    int wave = 1;
   
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Ufriv_Sofa")
        {


            sofaliv -= 1;
            Debug.Log(sofaliv);
            if (sofaliv == 0)
            {
                Debug.Log("dø dø dø d ødø dø døø ød");
                Debug.Log(sofaliv);
                Destroy(col.gameObject);
            }
            Destroy(gameObject);
        }
    }

    Vector2 startPosition;
    Vector2 goafter = new Vector2(19.0f,0f);
    [SerializeField] GameObject Ufriv_Sofa;
    [SerializeField] float speed;

    Rigidbody2D rb;
    

    
        

        //rb = GetComponent<Rigidbody2D>();
    

    void FixedUpdate()
    {

        //var step = speed * Time.deltaTime;
        //Vector2 newPosition = Vector2.MoveTowards(transform.position, Ufriv_Sofa.transform.position, step);
        if (GameObject.Find("Ufriv_Sofa") != null)
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, goafter, step);
        }

        //rb.MovePosition(newPosition);
    }
}