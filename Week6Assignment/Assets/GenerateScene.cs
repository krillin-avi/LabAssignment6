using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateScene : MonoBehaviour
{
    // Input Variables
    public int sizeOfForest;
    public GameObject[] trees;


    void Start()
    {
        InitVariables();
        CreateGround();
        CreateForest();
        CreatePyramid();
    }

    void InitVariables()
    {
        trees = new GameObject[sizeOfForest];
    }

    void CreateGround()
    {
        // Why does "new" keyword throw an error?
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.transform.localScale = new Vector3(5,1,5);
        ground.GetComponent<MeshRenderer>().material.color = Color.yellow;

    }

    void CreateForest()
    {
        // Local Variables
        float randomXPos;
        float randomYPos;
        float randomZPos;
        float randomXScale;
        float randomYScale;
        float randomZScale;
        float randomGreen;

        // Create For Loop to Instatiate Gameobjects From Array
        for (int i = 0; i < trees.Length; i++)
        {
            // Setting Random Position Ranges
            randomXPos = UnityEngine.Random.Range(1, 10);
            randomYPos = UnityEngine.Random.Range(1, 1);
            randomZPos = UnityEngine.Random.Range(1, 10);

            // Setting Random Position Scales
            randomXScale = UnityEngine.Random.Range(1, 3);
            randomYScale = UnityEngine.Random.Range(1, 15);
            randomZScale = UnityEngine.Random.Range(1, 3);

            // Random Green
            randomGreen = UnityEngine.Random.Range(50,200) / 255f;

            // Setting Properties for Tree at Each Index
            trees[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            trees[i].transform.position = new Vector3(randomXPos, randomYPos, randomZPos);
            // Need to Randomize the Color Green 
            trees[i].GetComponent<MeshRenderer>().material.color = new Color(0, randomGreen, 0);
            trees[i].transform.localScale = new Vector3(randomXScale, randomYScale, randomZScale);
        }
    }

    void CreatePyramid()
    {

        int baseSize = 5; 
        float cubeSize = 1.1f;

        GameObject baseCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        baseCube.transform.position = new Vector3(0, 1, 0);

        // Create For Loop to Instatiate Gameobjects
        for (int i = baseSize; i > 0; i--)
        {
            // Loop to create cubes in each layer
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(
                        baseCube.transform.position.x + (j - (i - 1) * 0.5f) * cubeSize,
                        baseCube.transform.position.y + (baseSize - i) * cubeSize, 
                        baseCube.transform.position.z + (k - (i - 1) * 0.5f) * cubeSize
                    );
                }
            }
        }


    }
        

}
