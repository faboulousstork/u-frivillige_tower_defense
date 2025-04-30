using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class skudhoming : MonoBehaviour
{
    public GameObject skud;
    public float speed;
    public List<GameObject> objects = new List<GameObject>();
    //public GameObject[] objects; // Array of objects to search through
    public GameObject nearestObject; // The nearest object found
    public int skudd 
    void Update()
    {
        nearestObject = FindNearestObject();
    }

    GameObject FindNearestObject()
    {
        GameObject closest = null;
        float shortestDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        
        GameObject obj1 = GameObject.Find("trekant");
        objects.Add(obj1);
        foreach (GameObject obj in objects)
        {
            if (obj == null) continue;

            float distance = Vector3.Distance(currentPosition, obj.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closest = obj;
            }
        }



        Debug.Log("over");
        
        
        skud.transform.position = Vector3.MoveTowards(skud.transform.position, closest.transform.position, speed);


     
        

        return closest;
    }

}
