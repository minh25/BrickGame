using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public static PlayerBehavior instance { get; private set; }

    private static int score;

    private void Awake()
    {
        instance = this;
        score = 0;
    }

    public int GetScore() { return score; }
    public void IncreaseScore() { score++; }
}
