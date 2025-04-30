using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skudhoming : MonoBehaviour
{
    public GameObject skud;
    public float speed;
    public GameObject[] objects; // Array of objects to search through
    public GameObject nearestObject; // The nearest object found

    void Update()
    {
        nearestObject = FindNearestObject();
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
            }
        }

        void OnMouseOver()
        {
            Debug.Log("over");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                skud.transform.position = Vector3.MoveTowards(skud.transform.position, closest.transform.position, speed);


            }
        }

        return closest;
    }

}
