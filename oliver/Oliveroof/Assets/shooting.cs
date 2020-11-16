using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;
    private Rigidbody rb;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        rb = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.LookAt(target.transform);
        if(time>=2)
        {
            time = 0;
            GameObject t = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(t, 5);
            t.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
        }
        
    }
}
