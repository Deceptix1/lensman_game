using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaaa : MonoBehaviour
{
    public Transform ta;
    public float a,x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
           x = 1f;

        }

        if (Input.GetKeyDown(KeyCode.A)){
            x = 1f;
        }
        if (Input.GetKeyDown(KeyCode.S)){
           x = 1f;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            
        }
        
        transform.position = new Vector3(ta.transform.position.x, ta.transform.position.y +a,transform.position.z);
    }
}
