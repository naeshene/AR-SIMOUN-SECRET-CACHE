using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager instance;

    void Awake()
    {
        instance = this; // para makeep BGM
        DontDestroyOnLoad(gameObject);
    }

}
