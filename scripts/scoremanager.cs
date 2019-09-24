using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoremanager : MonoBehaviour
{
    public Text sdisp;
    public int score=0;
    private void OnTriggerEnter2D(Collider2D other)
    
    {
        if(other.CompareTag("enemy"))
        {
            score++;
            Debug.Log(score);
        }

   }


     void Update()
    {
        sdisp.text = "Score: " + score.ToString();

    }
}
