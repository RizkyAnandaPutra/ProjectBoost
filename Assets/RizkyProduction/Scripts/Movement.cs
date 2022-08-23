using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        ProcessThrust();
    }

    public void ProcessInput()
    {
        if (Input.GetKey("up"))
        {
            print("up arrow key is held down");
        }

        if (Input.GetKey("down"))
        {
            print("down arrow key is held down");
        }
    }

    public void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up*mainThrust*Time.deltaTime);
            Debug.Log("Masuk");
        }
    }
}
