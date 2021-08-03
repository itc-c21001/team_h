using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) front();
        if (Input.GetKey("s")) buck();
        if (Input.GetKey("a")) left();
        if (Input.GetKey("d")) right();
    }
    public void front()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    public void buck()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    public void right()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    public void left()
    {
        transform.position -= transform.right * speed * Time.deltaTime;
    }
}
