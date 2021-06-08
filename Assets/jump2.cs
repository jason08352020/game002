using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jump2 : MonoBehaviour
{
    // Start is called before the first frame update
    
        public float jumpForce;
        public float gravityModifier;
        Rigidbody rb;
        bool isG = true;
        score sc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        rb.AddForce(Vector3.up * 500);
        sc = GameObject.Find("ball").GetComponent<score>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && sc.score1 < sc.goal && sc.score2 < sc.goal)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isG = false;
        }


    }
    void OnCollisionEnter(Collision collision)
    {
        isG = true;

    }

}

