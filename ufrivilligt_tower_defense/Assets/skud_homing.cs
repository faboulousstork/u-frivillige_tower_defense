using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class skud_homing : MonoBehaviour
{
    public float speed;
    //public static skud_homing Instance { get; private set; }
    public static List<GameObject> objects = new List<GameObject>();
    //public GameObject[] objects; // Array of objects to search through
    public static GameObject nearestObject; // The nearest object found 
    
    void Update()
    {
        nearestObject = FindNearestObject();
        if (nearestObject != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, nearestObject.transform.position, speed);
        }
    }

    GameObject FindNearestObject()
    {
        GameObject closest = null;
        float shortestDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        foreach (GameObject obj in objects)
        {
            if (obj == null) continue;

            float distance = Vector3.Distance(currentPosition, obj.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closest = obj;
                //Debug.Log("Den her funktion sker fakstiks");
               // Debug.Log(closest);
            }
        }

        return closest;
    }

}
