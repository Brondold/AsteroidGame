using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeManager : MonoBehaviour
{

    public float delay = 3f;

    public GameObject explosionEffetcs;

    float countdown;
    bool hasExplosed = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
            
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExplosed)
        {
            Explode();
            hasExplosed = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffetcs, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
