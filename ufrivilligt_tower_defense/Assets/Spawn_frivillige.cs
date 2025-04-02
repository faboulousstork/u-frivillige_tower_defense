using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class Spawn_frivilligt : MonoBehaviour
{
    public int ilive = 0;
    [SerializeField] GameObject Trekant;
Vector2 spawn = new Vector2(-27.5f,0f);
    public int wave = 1;
     public int spawen = 0;
     IEnumerator wavething(){
        for(int i =  0; i < wave; i++){
                spawen -= 1;
               GameObject duplicate = Instantiate(Trekant,spawn,Quaternion.identity);
               yield return new WaitForSeconds(0.2f);
            }
     }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    } 
        public int wawe = 0;
    void FixedUpdate()
    {
        wawe += 1; 
        if (Input.GetKey(KeyCode.Space) && wawe % 19 == 0){
            if (spawen <= 1){
           wave += 1;
           spawen = wave;
            Debug.Log("k");
          StartCoroutine(wavething());
            }
        }
    
}
}