using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ninja : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       anima.SetFloat("Walktree",Input.GetAxis("Vertical"));
        float z = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, z);
        transform.Rotate(0, rotatespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anima.SetTrigger("attack");
        }
        
    }
}
