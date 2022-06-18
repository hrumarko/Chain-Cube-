using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    public int Number;
    public TextMeshPro textMesh;
    public TextMeshPro[] arrText;
    public bool isMain;
    
    
    void Awake(){
        // float xCube = this.transform.position.x;
        // float xMax = 2.65f;
    }
    
    
   private void FixedUpdate() {
        
    
   }
    public void SetNumber(int num){
        Number = num;
        for(int i = 0; i < 6; i++){
            arrText[i].text = num.ToString();
        }
      
    }
    
    

}
