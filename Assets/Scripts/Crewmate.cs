using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crewmate
{
    public string FirstName;
    public string LastName;
    private TraitScriptableObject[] traits;
    public Crewmate(string firstName, string lastName, TraitScriptableObject[] traits)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.traits = traits;
    }
}
