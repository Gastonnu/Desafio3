using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Disparo()
    {
        Instantiate(bullet, transform);
    }

}
