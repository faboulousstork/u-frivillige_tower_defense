using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_to_skud_list : MonoBehaviour
{
    [SerializeField] GameObject Trekant;
    void Start()
    {
        skud_homing.objects.Add(Trekant);
    }
    
}
