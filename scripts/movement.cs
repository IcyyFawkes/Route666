using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class movement : MonoBehaviour
{
    public float speed;
    private Vector2 pos;
    public float offset;
    public float maxh;
    public float minh;
    public int health = 4;
    public Text hdisp;
    public GameObject gameover;
    private GameObject[] obstacles;
    public GameObject obstacleEffect;
    public GameObject spawner;
    public int noh;
    public Image[] hearts;
    public Sprite Fullheart;
    public Sprite Emptyheart;
    public GameObject monster;
    // Update is called once per frame
    void Update()

    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<health )
            {
                hearts[i].sprite = Fullheart;
            }
            else
            {
                hearts[i].sprite = Emptyheart;
            }
            if(i<noh)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }



        hdisp.text = health.ToString();
        if (health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);

            spawner.SetActive(false);

            obstacles = GameObject.FindGameObjectsWithTag("enemy");  // NEW
            foreach (var obstacle in obstacles) // NEW
            {
                Instantiate(obstacleEffect, obstacle.transform.position, Quaternion.identity); // NEW
                Destroy(obstacle); // NEW
            }

            Instantiate(obstacleEffect, monster.transform.position, Quaternion.identity);
            Destroy(monster);
        }
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow)&&transform.position.y < maxh)
        {
              pos = new Vector2(transform.position.x, transform.position.y + offset);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minh)
        {
              pos = new Vector2(transform.position.x, transform.position.y - offset);
        }
    }
}
