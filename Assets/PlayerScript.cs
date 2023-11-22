using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, z);
        transform.Rotate(0, rotatespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
    }
}
