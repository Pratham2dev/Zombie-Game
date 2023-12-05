using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ninja : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    public Animator anima;
    public GameObject Camera,childCamera;
    public float rotationSensitivity;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var x in GetComponentsInChildren<Rigidbody>()){
            x.isKinematic=true;
        }
        this.GetComponent<Rigidbody>().isKinematic=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
                Camera.transform.Rotate(0,Input.GetAxis("Mouse X")*rotationSensitivity*Time.deltaTime,0);
                childCamera.transform.Rotate(Input.GetAxis("Mouse Y")*rotationSensitivity*Time.deltaTime,0,0);
        }
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
