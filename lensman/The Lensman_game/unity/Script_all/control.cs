using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class control : MonoBehaviour
{  public float x,y,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p;
    public float movSpeed;
    float speedX, speedY;
    public float dist; 
    public Animator ani;

   

  public Vector2 ray_end;
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        x = 1f;
        y = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.W)){
            
            x = 0f;
            y = 1f;
            a = 0.75f;
            b = -0.25f;
            c = -0.75f;
            d = -0.25f;
            e = 0.25f;
            f = -0.25f;
            g = -0.25f;
            h = -0.25f;
            i = 0.5f;
            j = -0.25f;
            k = -0.5f;
            l = -0.25f;
            m = 0.375f;
            n = -0.25f;
            o = -0.375f;
            p = -0.25f;

            ani.SetBool("run",true);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
           
            

        }
        if(Input.GetKeyUp(KeyCode.W)){
            ani.SetBool("run",false);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
          
        }

        if (Input.GetKeyDown(KeyCode.A)){
            x = -1f;
            y = 0f;
            a = 0.25f;
            b = 0.75f;
            c = 0.25f;
            d = -0.75f;
            e = 0.25f;
            f = 0.25f;
            g = 0.25f;
            h = -0.25f;
            i = 0.25f;
            j = 0.5f;
            k = 0.25f;
            l = -0.5f;
            m = 0.25f;
            n = 0.375f;
            o = 0.25f;
            p = -0.375f;
            ani.SetBool("run",true);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
            
        }
        if(Input.GetKeyUp(KeyCode.A)){
            ani.SetBool("run",false);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
           
        }
        if (Input.GetKeyDown(KeyCode.S)){
            x = 0f;
            y = -1f;
            a = -0.75f;
            b = 0.25f;
            c = 0.75f;
            d = 0.25f;
            e = -0.25f;
            f = 0.25f;
            g = 0.25f;
            h = 0.25f;
            i = -0.5f;
            j = 0.25f;
            k = 0.5f;
            l = 0.25f;
            m = -0.375f;
            n = 0.25f;
            o = 0.375f;
            p = 0.25f;
            ani.SetBool("run",true);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
            
        }
        if(Input.GetKeyUp(KeyCode.S)){
            ani.SetBool("run",false);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
            
        }
        if (Input.GetKeyDown(KeyCode.D)){
            x = 1f;
            y = 0f;
            a = -0.25f;
            b = -0.75f;
            c = -0.25f;
            d = 0.75f;
            e = -0.25f;
            f = -0.25f;
            g = -0.25f;
            h = 0.25f;
            i = -0.25f;
            j = -0.5f;
            k = -0.25f;
            l = 0.5f;
            m = -0.25f;
            n = -0.375f;
            o = -0.25f;
            p = 0.375f;
            ani.SetBool("run",true);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
            
        }
        
        
        
        
        
        if(Input.GetKeyUp(KeyCode.D)){
            ani.SetBool("run",false);
            ani.SetFloat("Horizontal",x);
            ani.SetFloat("Vertical",y);
            
        }
        speedX = Input. GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input. GetAxisRaw("Vertical") * movSpeed;
        rb. velocity = new Vector2(speedX, speedY);

        //111111111
        RaycastHit2D one_a = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+c,y+d),dist);
        RaycastHit2D one_b = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x,y),dist);
        RaycastHit2D one_c = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+a,y+b),dist);
        //2222222222
        RaycastHit2D two_a = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+c,y+d),dist);
        RaycastHit2D two_b = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+g,y+h),dist);
        RaycastHit2D two_c = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x,y),dist);
        RaycastHit2D two_d = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+e,y+f),dist);
        RaycastHit2D two_e = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+a,y+b),dist);
        //33333333333
        RaycastHit2D three_a = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+c,y+d),dist);
        RaycastHit2D three_b = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+k,y+l),dist);
        RaycastHit2D three_c = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+g,y+h),dist);
        RaycastHit2D three_d = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x,y),dist);
        RaycastHit2D three_e = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+e,y+f),dist);
        RaycastHit2D three_f = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+i,y+j),dist);
        RaycastHit2D three_g = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+a,y+b),dist);

        //444444444444
        RaycastHit2D four_a = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+c,y+d),dist);
        RaycastHit2D four_b = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+k,y+l),dist);
        RaycastHit2D four_c = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+o,y+p),dist);
        RaycastHit2D four_d = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+g,y+h),dist);
        RaycastHit2D four_e = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x,y),dist);
        RaycastHit2D four_f = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+e,y+f),dist);
        RaycastHit2D four_g = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+m,y+n),dist);
        RaycastHit2D four_h = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+i,y+j),dist);
        RaycastHit2D four_i = Physics2D.Raycast(this.transform.position, Vector2.up*new Vector2(x+a,y+b),dist);
        
        
        //4444444444444
        if (four_a.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*5.3f, Color.blue);
        }
        if (four_b.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+k,y+l) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+k,y+l) * dist*5.3f, Color.blue);
        }
        if (four_c.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+o,y+p) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+o,y+p) * dist*5.3f, Color.blue);
        }
        if (four_d.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*5.3f, Color.blue);
        }
        if (four_e.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*3.98f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*3.98f, Color.blue);
        }
         if (four_f.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*5.3f, Color.blue);
        }
        if (four_g.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+m,y+n) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+m,y+n) * dist*5.3f, Color.blue);
        }
        if (four_h.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+i,y+j) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+i,y+j) * dist*5.3f, Color.blue);
        }
         if (four_i.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*5.3f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*5.3f, Color.blue);
        }
       
       


        //3333333333333333333333333

        if (three_a.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*3.7f, Color.yellow);
        }
        if (three_b.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+k,y+l) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+k,y+l) * dist*3.7f, Color.yellow);
        }
        if (three_c.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*3.7f, Color.yellow);
        }
        if (three_d.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*2.78f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*2.78f, Color.yellow);
        }
         if (three_e.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*3.7f, Color.yellow);
        }
        if (three_f.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+i,y+j) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+i,y+j) * dist*3.7f, Color.yellow);
        }
         if (three_g.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*3.7f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*3.7f, Color.yellow);
        }
       


        //22222222222222222222222222
        if (two_a.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*2.5f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist*2.5f, Color.green);
        }
        if (two_b.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*2.5f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+g,y+h) * dist*2.5f, Color.green);
        }
        if (two_c.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*1.87f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist*1.87f, Color.green);
        }
         if (two_d.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*2.5f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+e,y+f) * dist*2.5f, Color.green);
        }
         if (two_e.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*2.5f, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist*2.5f, Color.green);
        }




        //111111111111
        if (one_a.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+c,y+d) * dist, Color.red);
        }

        if (one_b.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x,y) * dist, Color.red);
        }
        if (one_c.collider != null)
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist, Color.blue);
        }
        else
        {
            Debug.DrawRay(this.transform.position, new Vector2(x+a,y+b) * dist, Color.red);
        }

        
        
       share_data.x = x;
       share_data.y = y;
       

    }
}

