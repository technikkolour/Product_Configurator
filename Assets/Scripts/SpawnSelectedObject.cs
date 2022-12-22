using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSelectedObject : MonoBehaviour
{
    public GameObject[] objects;

    private string type;

    public void SpawnObject(int index)
    {
        if (type == "Sails" && GameObject.FindGameObjectWithTag("Sails"))
            Destroy(GameObject.FindGameObjectWithTag("Sails"));
        if (type == "Oars" && GameObject.FindGameObjectWithTag("Oars"))
            Destroy(GameObject.FindGameObjectWithTag("Oars"));

        if (index > 0)
        {
            GameObject obj = Instantiate(objects[index], this.transform.position, Quaternion.identity);
            obj.tag = type;
        }
        
    }

    public void SetType(string type)
    {
        this.type = type;
    }
}
