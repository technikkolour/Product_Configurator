using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceCalculator : MonoBehaviour
{
    private int type;

    private int[][] prices;

    private void Start()
    {
        prices = new int[][] { 
            new int[] { 0, 30, 80 },
            new int[] { 0, 10, 45}, 
            new int[] { 0, 10, 25} };
        
    }

    public void setDropdownType(int type)
    {
        this.type = type;
    }

    public void updateSelections(int value)
    {
        this.GetComponent<ObjectInteraction>().SetSelections(type, prices[type][value]);
        this.GetComponent<ObjectInteraction>().calculatePrices();
    }
}
