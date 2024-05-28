using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Script : MonoBehaviour
{
    public Rigidbody2D player2;
    public int player_speed = 4;
    private float timer2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            //Debug.Log("up button pressed player 2");
            player2.velocity = Vector2.up * player_speed;
            timer2 = 0;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            //Debug.Log("down button pressed player 2");
            player2.velocity = Vector2.down * player_speed;
            timer2 = 0;
        }

        else if (timer2 >= 0.2)
        {
            player2.velocity = Vector2.zero;
            timer2 = 0;
        }
    }
}
