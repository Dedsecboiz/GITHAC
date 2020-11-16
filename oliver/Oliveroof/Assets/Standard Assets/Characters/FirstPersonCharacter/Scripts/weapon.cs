using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    public int CurAmmo;
    public int MaxAmmo;
    public float speed;
    public float FireRate;
    private float lastShootTime;
    public bool isPlayer;
    // Start is called before the first frame update'

    private void Awake()
    {
        if (GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        }
    }

    public bool CanShoot()
    { if(Time.time- lastShootTime>= FireRate)
        {
            if (CurAmmo > 0)
            {
                return true;
            }
        }

        return false;
    }

    public void Shoot()
    {
        lastShootTime = Time.time;
        CurAmmo--;
        GameObject projectile = Instantiate(bullet, muzzle.position, muzzle.rotation);
        projectile.GetComponent<Rigidbody>().velocity = muzzle.forward * speed;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
