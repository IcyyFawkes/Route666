using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpt : MonoBehaviour
{
    public GameObject Obs;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Obs, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
