using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class functionality_2 : MonoBehaviour
{   

 
   private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name == "ship"){
            SceneManager.LoadScene("maybe_earth");
        }
   }

    
}
