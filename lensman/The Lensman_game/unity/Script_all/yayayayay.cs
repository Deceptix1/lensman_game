using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yayayayay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            
            if (share_data.ad == "maybe_earth" ){
                SceneManager.LoadScene("maybe_earth");
                
            }
            if (share_data.ad == "ice_planet"){
                SceneManager.LoadScene("ice_planet");
            }
        }
    }
}
