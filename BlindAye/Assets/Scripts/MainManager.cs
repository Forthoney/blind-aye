using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int numOfCrew = 8;
    public float food;
    public float medicine;
    public float navigationProgress;
    public Crewmate[] CrewMates;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
