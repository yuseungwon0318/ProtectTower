using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(instance  == null)
            {
                instance = FindAnyObjectByType<GameManager>();
            }
            return Instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private float exp;
    private float maxExp;

    private void Start()
    {
        exp = 0;
    }
}
