using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour
{   public GameObject wasd, aa;

    
    void OnTriggerEnter2D(Collider2D col){
    
        if (col.gameObject.name.Equals (wasd)){
            if (Input.GetKeyDown(KeyCode.Q)){
                wasd.SetActive(false);
                aa.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if (col. gameObject.name. Equals (wasd)){
            if (Input.GetKeyDown(KeyCode.Q)){
                wasd.SetActive(true);
                aa.SetActive(false);
            }
        }
    }
}
