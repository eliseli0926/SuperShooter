using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int amount;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            print("duplicated scoremanager, ignoring this one.");
        }
    }
}
