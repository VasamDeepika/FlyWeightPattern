using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusinessCardDisplay : MonoBehaviour
{
    public BusinessCard businessCard;
    public Text nameText;
    public Image logoImage;
    public Text healthText, scoreText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = businessCard.name;
        logoImage.sprite = businessCard.image;
        scoreText.text = businessCard.score.ToString();
        healthText.text = businessCard.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
