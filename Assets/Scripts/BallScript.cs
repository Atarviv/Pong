using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    bool ismoving;
    // Start is called before the first frame update
    void Start()
    {
        ismoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!ismoving)
            { 
            int x = Random.Range(200, 401);
            int y = Random.Range(200, 401);
            int x_dir = Random.Range(0, 2);
            int y_dir = Random.Range(0, 2);
            if (x_dir == 0) x_dir--;
            if (y_dir == 0) y_dir--;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(x * x_dir, y * y_dir));
            ismoving = true;
            }
        if (transform.position.x > 12.5f || transform.position.x < -12.5f)
            {
            if (transform.position.x > 0) GameObject.Find("PointsHandler").GetComponent<PointsScript>().first++;
            else GameObject.Find("PointsHandler").GetComponent<PointsScript>().second++;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.position = new Vector3(0, 0, 0);
            ismoving = false;
            }
    }
}
