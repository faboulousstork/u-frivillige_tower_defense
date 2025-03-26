using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;




public class Ufriv_spawner : MonoBehaviour
{
    
    int liv = 10;
    int wave = 1;
    private GameObject spawner;
    void Start()
    {

        spawner = GameObject.Find("spawner");
        
        public Spawn_frivillige Spawn_frivilligt;
        Spawn_frivilligt.ilive = 1;

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Ufriv_Sofa")
        {

                
            liv -= 1;
            Debug.Log(liv);
            if (liv == 0)
            {
                Destroy(col.gameObject);
            }
            Destroy(gameObject);
            spawner.GetComponents<>
        }
    }

    Vector2 startPosition;
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
            transform.position = Vector2.MoveTowards(transform.position, Ufriv_Sofa.transform.position, step);
        }
        //rb.MovePosition(newPosition);
    }
}
