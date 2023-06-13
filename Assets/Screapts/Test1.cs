using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 vector;
    public int CubesAmountFib;
    public int CubesAmountSin;

    void Start()
    {
        for (int i = 0; i < CubesAmountFib; i++)
        {
            Instantiate(Cube, vector, Quaternion.identity);
            vector = new Vector3(0f, vector.y + Fib(i) + 1f, 0f);
        }
        for (int i = 0; i < CubesAmountSin; i++)
        {
            vector = new Vector3(i, Mathf.Sin(i), 5f);
            Instantiate(Cube, vector, Quaternion.identity);
        }
    }
        public int Fib(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return Fib(x - 2) + Fib(x - 1);
            }
        }
    private void OnEnable()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                var position = new Vector3(x, y, 0f);
                var spawnedCube = Instantiate(Cube, position, Quaternion.identity, transform);
                spawnedCube.transform.localScale = Vector3.one * 0.9f;
                spawnedCube.GetComponent<MeshRenderer>().material.color = new Color(x / 5f, y / 5f, 0f, 0f);
            }
        }
    }

}


