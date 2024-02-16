using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateScene : MonoBehaviour
{
    // Input Variables
    public int sizeOfForest;

    //public int stonesRequired;
    public GameObject[] trees;
    //public GameObject[] stones;


    void Start()
    {
        InitVariables();
        CreateGround();
        CreateForest();
        //CreatePyramid();
    }

    void InitVariables()
    {
        trees = new GameObject[sizeOfForest];
    }

    void CreateGround()
    {
        // Why does "new" keyword throw an error?
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);

    }

    void CreateForest()
    {
        float randomX; 
        float randomY; 
        float randomZ;

        // Create Forloop and Instatiate Gameobject Prims = to "sizeofforest"
        for (int i = 0; i < trees.Length; i++)
        {
            randomX = Random.Range(1, 5);
            randomY = Random.Range(1, 1);
            randomZ = Random.Range(1, 5);

            trees[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            trees[i].transform.position = new Vector3(randomX, randomY, randomZ);
            trees[i].
       
        }
    }
}
