using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cubeq : MonoBehaviour
{
    public int Number;
    public TextMeshPro textMesh;
    public TextMeshPro[] arrText;
    
    
    
   
    public void SetNumber(int num){
        Number = num;
        for(int i = 0; i < 6; i++){
            arrText[i].text = num.ToString();
        }
      
    }
    
    

}
