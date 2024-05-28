using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class goalpost_script : MonoBehaviour
{
    public int player_score = 0;
    public Text score_card;
    public Logic_script logic;
    bool start_timer = false;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if (start_timer)
        {
            timer += Time.deltaTime;

            if (timer >= 2)
            {
                logic.Reset_Map();
                start_timer = false;
                timer = 0;
            }
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        player_score += 1;
        score_card.text = player_score.ToString();
        timer = 0;
        start_timer = true;
    }
}
