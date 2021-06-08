using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move2 : MonoBehaviour
{
    public float MoveSpeed;
    score sc;//, jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.Find("ball").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sc.score1 < sc.goal && sc.score2 < sc.goal)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * MoveSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * -Time.deltaTime * MoveSpeed);
            }
            /*   if (Input.GetKey(KeyCode.UpArrow))
               {
                   GetComponent<Rigidbody>().AddForce(0, 200, 0);
               }
            */
        }
    }
}
