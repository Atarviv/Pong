using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y<5.1f)
            {
            transform.Translate(0, 0.02f, 0);
            }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -5.1f)
            {
            transform.Translate(0, -0.02f, 0);
            }
        }
}
