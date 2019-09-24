using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;
    public int dmg = 1;
    public GameObject effect;
    public GameObject oof;
     void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<movement>().health -= dmg;
            Debug.Log(other.GetComponent<movement>().health);
            Destroy(gameObject);
            Instantiate(oof, transform.position, Quaternion.identity);
        }
    }
}
