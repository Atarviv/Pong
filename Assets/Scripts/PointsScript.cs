using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public GameObject Panel1, Panel2, Ball;
    public Text points1,points2;
    public int first, second;
    // Start is called before the first frame update
    void Start()
    {
        first = 0;
        second = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (first == 3)
            {
            Destroy(Ball);
            Panel1.SetActive(true);
            }
        if (second == 3)
            {
            Destroy(Ball);
            Panel2.SetActive(true);
            }
            points1.text = first.ToString();
        points2.text = second.ToString();
    }
}
