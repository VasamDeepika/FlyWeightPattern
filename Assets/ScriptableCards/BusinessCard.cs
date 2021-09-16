using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "BusinessCard", order = 50)]
public class BusinessCard : ScriptableObject
{
    public new string name;
    public int score, health;
    public Sprite image;

}
