using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class FindNearObject : MonoBehaviour
{
    public List<GameObject> balls;
    public List<float> ballsDistance = new List<float>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Find();
    }

    private void Find()
    {
        balls = GameObject.FindGameObjectsWithTag("球體").ToList();

        for (int i = 0; i < balls.Count; i++) ballsDistance.Add(Vector3.Distance(transform.position, balls[i].transform.position));

        float min = ballsDistance.Min();

        int index = ballsDistance.IndexOf(min);

        balls[index].transform.localScale = Vector3.one * 3;
    }
}
