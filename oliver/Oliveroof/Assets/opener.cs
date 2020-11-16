using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opener : MonoBehaviour
{
    public GameObject character;
    public float distance;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {if(Vector3.Distance(character.transform.position,transform.position)<distance)
        {
            anim.SetBool("character_nearby", true);
        }
        else
        {
            anim.SetBool("character_nearby", false);
        }
    }
}
