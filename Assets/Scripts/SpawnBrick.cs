using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBrick : MonoBehaviour
{
    public GameObject brick;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -4; i <= 4; i++)
            for (int j = 0; j < 5; j++)
                Instantiate(brick, new Vector3(i*1.5f, j, 0), Quaternion.identity);
    }
}
