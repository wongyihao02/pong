using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Script : MonoBehaviour
{
    public Rigidbody2D player;
    public int player_speed = 4;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)    
        {
            //Debug.Log("up button pressed");
            player.velocity = Vector2.up * player_speed;
            timer = 0;
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("down button pressed");
            player.velocity = Vector2.down * player_speed;
            timer = 0;
        }
        
        else if (timer >= 0.3)
        {
            player.velocity = Vector2.zero;
            timer = 0;
        }

        

        
    }
}
