using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "TraitData", menuName = "ScriptableObjects/Trait")]
public class TraitScriptableObject : ScriptableObject
{
    public string traitName;
    public string description;
    [Header("Opinion Modifiers")]
    public float opinionOfYouModifier = 1;
    public TraitScriptableObject[] dislikedTraits;
    public TraitScriptableObject[] likedTraits;
    [Header("Important Position Aptitude")]
    public float cookingAptitude = 1;
    public float navigatingAptitude = 1;
    public float curingAptitude = 1;
    public float insight = 1;
    [Header("Survivability")] 
    public float hungerModifier = 1;
    public float healingSpeed = 1;
    [Header("Communicating")] 
    public float foodNeeds = 1;
    public float medicineNeeds = 1;
    public float discontent = 1;
    public float honesty = 0.9f;
}