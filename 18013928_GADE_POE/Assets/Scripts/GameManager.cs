using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public int Round
    {
        get { return round;}
    }
	// Update is called once per frame
	void Update () {
        UpdateUnits();
        UpdateBuildings();
        round++;
	}
    void UpdateUnits()
    {
        foreach (string faction in factions)
        {
            string[]
        }
    }
    privste void StayInBounds(Unit unit)
    {
        Vector3 unitPosition = unit.transform.position;
        if(unitPosition.x < 0)
        {
            unitPosition.x = 0;
        }
        else if(unitPosition.x >= width)
        {
            unitPosition.x = width - 1;
        }
        if(unitPosition.y <0)
        {
            unitPosition.y = 0;
        }
        else if (unitPosition.y >= height)
        {
            unitPosition.y = height - 1;
        }
        unit.transform.position =
    }
}
