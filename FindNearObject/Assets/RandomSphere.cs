using UnityEngine;

public class RandomSphere : MonoBehaviour
{
    public Transform ball;

    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        for (int i = 0; i < 10; i++)
        {
            float x = Random.Range(-15f, 15f);
            float z = Random.Range(-15f, 15f);

            Vector3 pos = new Vector3(x, 5, z);

            Instantiate(ball, pos, Quaternion.identity);
        }
    }
}
