using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateScene : MonoBehaviour
{
    // Input Variables
    public int sizeOfForest;
    public int stonesRequired;
    public GameObject[] trees;
    public GameObject[] stones;

    // Globals
    //GameObject ground;

    void Start()
    {
        //InitVariables();
        CreateGround();
        //CreateForest();
        //CreatePyramid();
    }


    void CreateGround()
    {
        // Why does "new" keyword throw an error?
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);

    }

    //void 
}
