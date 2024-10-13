using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class mapManager : MonoBehaviour
{
    public Tilemap map;

    public GameObject aa;
    public string a;
    control script;

   
    void Start()
    {
        a = SceneManager.GetActiveScene().name;
        script = GameObject.Find("player").GetComponent<control>();
        share_data.ad = a;
        this.transform.position = share_data.bc;
    }
    



      


    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {   Vector2 one_1 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.c,script.y+script.d)*script.dist;
            Vector2 one_2 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x,script.y)*script.dist;
            Vector2 one_3 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.a,script.y+script.b)*script.dist;
            Vector2 two_1 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.c,script.y+script.d)*script.dist*2.5f;
            Vector2 two_2 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.g,script.y+script.h)*script.dist*2.5f;
            Vector2 two_3 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x,script.y)*script.dist*1.87f;
            Vector2 two_4 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.e,script.y+script.f)*script.dist*2.5f;
            Vector2 two_5 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.a,script.y+script.b)*script.dist*2.5f;
            Vector2 three_1 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.c,script.y+script.d)*script.dist*3.7f;
            Vector2 three_2 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.k,script.y+script.l)*script.dist*3.7f;
            Vector2 three_3 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.g,script.y+script.h)*script.dist*3.7f;
            Vector2 three_4 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x,script.y)*script.dist*2.78f;
            Vector2 three_5 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.e,script.y+script.f)*script.dist*3.7f;
            Vector2 three_6 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.i,script.y+script.j)*script.dist*3.7f;
            Vector2 three_7 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.a,script.y+script.b)*script.dist*3.7f;
            Vector2 four_1 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.c,script.y+script.d)*script.dist*5.3f;
            Vector2 four_2 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.k,script.y+script.l)*script.dist*5.3f;
            Vector2 four_3 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.o,script.y+script.p)*script.dist*5.3f;
            Vector2 four_4 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.g,script.y+script.h)*script.dist*5.3f;
            Vector2 four_5 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x,script.y)*script.dist*3.98f;
            Vector2 four_6 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.e,script.y+script.f)*script.dist*5.3f;
            Vector2 four_7 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.m,script.y+script.n)*script.dist*5.3f;
            Vector2 four_8 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.i,script.y+script.j)*script.dist*5.3f;
            Vector2 four_9 = new Vector2(aa.transform.position.x,aa.transform.position.y) + new Vector2(script.x+script.a,script.y+script.b)*script.dist*5.3f;
            
            
            
            
            
            
            
            
            
            
            Vector3Int grid_1_1 = map.WorldToCell(one_1);
            Vector3Int grid_1_2 = map.WorldToCell(one_2);
            Vector3Int grid_1_3 = map.WorldToCell(one_3);
            Vector3Int grid_2_1 = map.WorldToCell(two_1);
            Vector3Int grid_2_2 = map.WorldToCell(two_2);
            Vector3Int grid_2_3 = map.WorldToCell(two_3);
            Vector3Int grid_2_4 = map.WorldToCell(two_4);
            Vector3Int grid_2_5 = map.WorldToCell(two_5);
            Vector3Int grid_3_1 = map.WorldToCell(three_1);
            Vector3Int grid_3_2 = map.WorldToCell(three_2);
            Vector3Int grid_3_3 = map.WorldToCell(three_3);
            Vector3Int grid_3_4 = map.WorldToCell(three_4);
            Vector3Int grid_3_5 = map.WorldToCell(three_5);
            Vector3Int grid_3_6 = map.WorldToCell(three_6);
            Vector3Int grid_3_7 = map.WorldToCell(three_7);
            Vector3Int grid_4_1 = map.WorldToCell(four_1);
            Vector3Int grid_4_2 = map.WorldToCell(four_2);
            Vector3Int grid_4_3 = map.WorldToCell(four_3);
            Vector3Int grid_4_4 = map.WorldToCell(four_4);
            Vector3Int grid_4_5 = map.WorldToCell(four_5);
            Vector3Int grid_4_6 = map.WorldToCell(four_6);
            Vector3Int grid_4_7 = map.WorldToCell(four_7);
            Vector3Int grid_4_8 = map.WorldToCell(four_8);
            Vector3Int grid_4_9 = map.WorldToCell(four_9);



            
            
            
            
            
            
            
            TileBase selected_tile_1_1 = map.GetTile(grid_1_1);
            TileBase selected_tile_1_2 = map.GetTile(grid_1_2);
            TileBase selected_tile_1_3 = map.GetTile(grid_1_3);
            TileBase selected_tile_2_1 = map.GetTile(grid_2_1);
            TileBase selected_tile_2_2 = map.GetTile(grid_2_2);
            TileBase selected_tile_2_3 = map.GetTile(grid_2_3);
            TileBase selected_tile_2_4 = map.GetTile(grid_2_4);
            TileBase selected_tile_2_5 = map.GetTile(grid_2_5);
            TileBase selected_tile_3_1 = map.GetTile(grid_3_1);
            TileBase selected_tile_3_2 = map.GetTile(grid_3_2);
            TileBase selected_tile_3_3 = map.GetTile(grid_3_3);
            TileBase selected_tile_3_4 = map.GetTile(grid_3_4);
            TileBase selected_tile_3_5 = map.GetTile(grid_3_5);
            TileBase selected_tile_3_6 = map.GetTile(grid_3_6);
            TileBase selected_tile_3_7 = map.GetTile(grid_3_7);
            TileBase selected_tile_4_1 = map.GetTile(grid_4_1);
            TileBase selected_tile_4_2 = map.GetTile(grid_4_2);
            TileBase selected_tile_4_3 = map.GetTile(grid_4_3);
            TileBase selected_tile_4_4 = map.GetTile(grid_4_4);
            TileBase selected_tile_4_5 = map.GetTile(grid_4_5);
            TileBase selected_tile_4_6 = map.GetTile(grid_4_6);
            TileBase selected_tile_4_7 = map.GetTile(grid_4_7);
            TileBase selected_tile_4_8 = map.GetTile(grid_4_8);
            TileBase selected_tile_4_9 = map.GetTile(grid_4_9);


            share_data.keep_1_1 = selected_tile_1_1;
            share_data.keep_1_2 = selected_tile_1_2;
            share_data.keep_1_3 = selected_tile_1_3;

            share_data.keep_2_1 = selected_tile_2_1;
            share_data.keep_2_2 = selected_tile_2_2;
            share_data.keep_2_3 = selected_tile_2_3;
            share_data.keep_2_4 = selected_tile_2_4;
            share_data.keep_2_5 = selected_tile_2_5;

            share_data.keep_3_1 = selected_tile_3_1;
            share_data.keep_3_2 = selected_tile_3_2;
            share_data.keep_3_3 = selected_tile_3_3;
            share_data.keep_3_4 = selected_tile_3_4;
            share_data.keep_3_5 = selected_tile_3_5;
            share_data.keep_3_6 = selected_tile_3_6;
            share_data.keep_3_7 = selected_tile_3_7;

            share_data.keep_4_1 = selected_tile_4_1;
            share_data.keep_4_2 = selected_tile_4_2;
            share_data.keep_4_3 = selected_tile_4_3;
            share_data.keep_4_4 = selected_tile_4_4;
            share_data.keep_4_5 = selected_tile_4_5;
            share_data.keep_4_6 = selected_tile_4_6;
            share_data.keep_4_7 = selected_tile_4_7;
            share_data.keep_4_8 = selected_tile_4_8;
            share_data.keep_4_9 = selected_tile_4_9;



           share_data.bc= this.transform.position;

            SceneManager.LoadScene("picture");

           
        }
        
    }
}

