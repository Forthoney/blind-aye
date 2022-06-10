using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [SerializeField]
    private int numOfTraits = 3;
    private static readonly string[] FirstNames = {"Abby", "Abe", "Aarfy", "Ben", "Blackbeard", "John", "Jack", "Jamie", "Jill"};

    private static readonly string[] LastNames = {"Sparrow", "Smith", "Tanner"};
    public void SetupGame()
    {
        SetDefaultResourceValues();
        PopulateCrewmates(MainManager.Instance.numOfCrew);
    }

    private void SetDefaultResourceValues()
    {
        MainManager.Instance.food = 100f;
        MainManager.Instance.medicine = 50f;
        MainManager.Instance.navigationProgress = 0f;
    }

    private Crewmate CreateCrewmate()
    {
        string firstName = FirstNames[Random.Range(0, FirstNames.Length)];
        string lastName = LastNames[Random.Range(0, LastNames.Length)];
        TraitScriptableObject[] traits = new TraitScriptableObject[numOfTraits];
        for (int i = 0; i < numOfTraits; i++)
        {
            
        }

        return new Crewmate(firstName, lastName, traits);
    }

    private void PopulateCrewmates(int numOfCrew)
    {
        
        MainManager.Instance.CrewMates = new Crewmate[numOfCrew];
        for (int i = 0; i < numOfCrew; i++)
        {
            MainManager.Instance.CrewMates[i] = CreateCrewmate();
        }
    }
}
