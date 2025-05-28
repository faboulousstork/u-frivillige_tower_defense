using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using UnityEngine.UI;
public class Ryk_og_de : MonoBehaviour
{
    //public text Pengetext;
    public static int penge = 18;
    public Text uiText; //= Pengetext;
    void Start()
    {
        Debug.Log("Og en ny trekant er blevet f�dt");
        uiText.text = "Penge start: " + penge.ToString();
    }
   // int wave = 1;
    int liv = 5;
    void OnTriggerEnter2D(Collider2D col)
    {
   
        if (col.gameObject.name == "skud(Clone)")
        {

            liv -= 1;
            Destroy(col.gameObject);
            if (liv == 0)
            {
                Destroy(gameObject);
                penge += 1;
                Debug.Log(penge);
            }
        }

        if (col.gameObject.name == "Ufriv_Sofa")
        {


            Sofa_script_liv.sofalivg -= 1;
            if (Sofa_script_liv.sofalivg == 0)
            {
                Destroy(col.gameObject);
            }
            Destroy(gameObject);
        }




    }
    



    void Update()
    {
        uiText.text = "Penge: " + penge.ToString();
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