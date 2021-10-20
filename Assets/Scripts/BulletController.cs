using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed = 0f;
    public Vector3 direction = new Vector3(0, 0, 0);
    public int damage = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

}
