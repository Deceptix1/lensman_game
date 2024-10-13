using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tele : MonoBehaviour
{   public GameObject aa;
   void OnTriggerExit( ){

       if(share_data.x == 1f & share_data.y == 0f){
        aa.transform.position = new Vector3(-77f,aa.transform.position.y,aa.transform.position.z);
       } 
       if(share_data.x == -1f & share_data.y == 0f){
        aa.transform.position = new Vector3(5f,aa.transform.position.y,aa.transform.position.z);
       }
       if(share_data.x == 0f & share_data.y == -1f){
        aa.transform.position = new Vector3(aa.transform.position.x,-4.7f,aa.transform.position.z);
       }
       if(share_data.x == 0f & share_data.y == -1f){
        aa.transform.position = new Vector3(aa.transform.position.y,49.8f,aa.transform.position.z);
       }
    
   }
    void OnTriggerEnter( ){

       if(share_data.x == 1f & share_data.y == 0f){
        aa.transform.position = new Vector3(-77f,aa.transform.position.y,aa.transform.position.z);
       } 
       if(share_data.x == -1f & share_data.y == 0f){
        aa.transform.position = new Vector3(5f,aa.transform.position.y,aa.transform.position.z);
       }
       if(share_data.x == 0f & share_data.y == -1f){
        aa.transform.position = new Vector3(aa.transform.position.x,-4.7f,aa.transform.position.z);
       }
       if(share_data.x == 0f & share_data.y == -1f){
        aa.transform.position = new Vector3(aa.transform.position.y,49.8f,aa.transform.position.z);
       }
    
   }
    // Update is called once per frame
    void Update()
    {
        
    }
}
