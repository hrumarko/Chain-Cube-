using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Cube : MonoBehaviour
{
    
    public GameObject cubePrefab;
    public TextMeshPro textMesh;
    [HideInInspector]public Material CubeColor;  
    [HideInInspector]public int Num;
    
    public Material[] meshRender;
    [HideInInspector] public int[] nums;
    public Color[] colors;
    
    Rigidbody rb;

    private void Awake() {
        // meshRender = cubePrefab.GetComponent<Material>();
        nums = new int[]{2, 4, 8, 16, 32, 64};
    }
    public void SetColor(int numbe){
        cubePrefab.GetComponent<MeshRenderer>().material = meshRender[numbe];
        // meshRender.color = color;
        
    }
    
    public void SetNumber(int number){
        Num = number;
        textMesh.text = number.ToString();
        

    }
  
}
