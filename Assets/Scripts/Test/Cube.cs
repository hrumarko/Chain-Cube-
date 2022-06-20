using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{   
    public Material[] materials;
    public int[] numbers;
    public int Number;
    public TextMeshPro textMesh;
    public TextMeshPro[] arrText;
    public bool isMain;
    
    
    
    
    void Start(){
        // materials = new Material[12];
        Debug.Log(materials.Length);
        
        
    }
    
    
   
    public void SetNumber(int num){
        
        Number = num;
        for(int i = 0; i < 6; i++){
            arrText[i].text = num.ToString();
        }
      
    }

    public void SetColor(int numb){
        
        gameObject.GetComponent<MeshRenderer>().material = materials[numb]; 
        
    }
    
    

}
