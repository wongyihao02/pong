using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Logic_script : MonoBehaviour
{
    public GameObject player_1;
    public GameObject player_2;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float random_float_gen(float min_abs , float max_abs)
    {
        int sign = Random.Range(-1 , 1);

        if (sign == 0)
        {
            sign = 1;
        }

        float ans = Random.Range(min_abs, max_abs);

        ans *= sign;
        return ans;
    }
    public void Reset_Map()
    {
        Debug.Log("resetted");
        player_1.GetComponent<Rigidbody2D>().transform.position = new Vector3(-5.9f , 0.19f , 0.0f);
        player_2.GetComponent<Rigidbody2D>().transform.position = new Vector3(5.9f, 0.19f, 0.0f);
        ball.GetComponent<Rigidbody2D>().transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(random_float_gen(4.0f , 6.0f), random_float_gen(4.0f, 6.0f));
    }
}
