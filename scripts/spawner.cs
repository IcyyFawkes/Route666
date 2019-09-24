using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawner : MonoBehaviour
{
    public GameObject[] obsp;
    private float tbs;
    public float startt;
    public float dtime;
    public float mint= 0.65f;


    private void Update()
    {
        if (tbs <= 0)
        {
            int rand = Random.Range(0, obsp.Length);
            Instantiate(obsp[rand], transform.position, Quaternion.identity);
            tbs = startt;
            if (startt > mint)
            {
                startt -= dtime;
            }
        }
        else
        {
            tbs -= Time.deltaTime;
        }

    }

}
