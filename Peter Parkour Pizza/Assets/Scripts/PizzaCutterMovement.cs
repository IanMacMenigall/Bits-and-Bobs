using UnityEngine;
using System.Collections;

public class PizzaCutterMovement : MonoBehaviour {

    public GameObject cutter;
    public float moveSpeed;
    public Transform currentPoint;
    public Transform[] points;
    public int pointSelection;

    // Use this for initialization
    void Start()
    {

        currentPoint = points[pointSelection];

    }

    // Update is called once per frame
    void Update()
    {

        cutter.transform.position = Vector3.MoveTowards(cutter.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);


        if (cutter.transform.position == currentPoint.position)
        {
            pointSelection++;

            if (pointSelection == points.Length)
            {
                pointSelection = 0;
            }

            currentPoint = points[pointSelection];
        }

    }
}