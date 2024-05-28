using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_Script : MonoBehaviour
{
    public Rigidbody2D ball;
    public Logic_script logic;
    float timer = 0;
    bool started = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("script_reference").GetComponent<Logic_script>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                ball.velocity = new Vector2(logic.random_float_gen(4.0f, 6.0f), logic.random_float_gen(4.0f, 6.0f));
                started = false;
            }
        }
    }
}
