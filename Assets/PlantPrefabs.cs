using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantPrefabs : MonoBehaviour
{
    [SerializeField]
    private PlantData info;
    private SetPlantInfo setPlantInfo;
    private void Start()
    {
        setPlantInfo = GameObject.FindGameObjectWithTag("PlantInfo").GetComponent<SetPlantInfo>();
    }
    private void OnMouseDown()
    {
        setPlantInfo.OpenPlantPanel();
        setPlantInfo.plantName.text = info.Name;
        setPlantInfo.threatLevel.text = info.PlantThreat.ToString();
        setPlantInfo.plantIcon.GetComponent<RawImage>().texture = info.Icon;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && info.PlantThreat == PlantData.THREAT.High)
        {
            PlayerController.dead = true;
        }
    }
}
