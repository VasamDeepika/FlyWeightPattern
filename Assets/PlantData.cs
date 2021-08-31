using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Plant Data", menuName = "Plant Menu", order = 50)]
public class PlantData : ScriptableObject
{
    public enum THREAT { None, Low, Moderate, High}
    [SerializeField]
    private string plantName;

    [SerializeField]
    private THREAT plantThreat;

    [SerializeField]
    private Texture icon;

    public string Name { get { return plantName; } }
    public THREAT PlantThreat { get { return plantThreat; } }
    public Texture Icon { get { return icon; } }

}
