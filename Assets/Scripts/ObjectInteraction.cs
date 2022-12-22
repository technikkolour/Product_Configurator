using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Mesh[] raftMeshes;

    private int totalPrice;
    private int[] selectedOptions;

    public TMP_Text priceDisplayed;

    void Start()
    {
        totalPrice = 0;
        selectedOptions = new int[3];
    }

    void Update()
    {     
        if (totalPrice == 0) priceDisplayed.text = "Free!";
        else if (totalPrice > 0) priceDisplayed.text = "$" + totalPrice;
    }

    public void SetSelections(int index, int value)
    {
        selectedOptions[index] = value;
    }

    public void changeColour(float value)
    {
        Renderer renderer = this.GetComponent<Renderer>();
        Material material = renderer.material;

        material.color = Color.HSVToRGB(value, 0.5f, 1);
    }

    public void calculatePrices()
    {
        totalPrice = 0;

        for (int i = 0; i < 3; i++)
            totalPrice += selectedOptions[i];
    }

    public void changeAppearance(int index)
    {
        MeshFilter mesh;

        mesh = this.GetComponent<MeshFilter>();
        mesh.mesh = raftMeshes[index];

        switch (index)
        {
            case 0:
                this.transform.localScale = new Vector3(1, 0.1f, 0.1f);
                this.transform.position = new Vector3((float)0.5, (float)-0.25, 0);
                this.transform.localRotation = Quaternion.Euler(90, 30, 0);
                break;
            case 1:
                this.transform.localScale = new Vector3(1, 0.5f, 0.05f);
                this.transform.position = new Vector3((float)0.5, (float)-0.20, 0);
                this.transform.localRotation = Quaternion.Euler(90, 30, 0);
                break;
            case 2:
                this.transform.localScale = new Vector3(1, 0.4f, 0.2f);
                this.transform.position = new Vector3((float)0.5, (float)-0.35, 0);
                this.transform.localRotation = Quaternion.Euler(270, 170, 10);
                break;

        }

    }
}
