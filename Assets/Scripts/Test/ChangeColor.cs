using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Cube cubColor;

    void Awake(){
        cubColor = GetComponent<Cube>();
    }
    
    
    public void CheckColor(int num){
        cubColor.Number = num;

        if(cubColor.Number == 2){
            cubColor.SetColor(0);
        }

        if(cubColor.Number == 4){
            cubColor.SetColor(1);
        }

        if(cubColor.Number == 8){
            cubColor.SetColor(2);
        }

        if(cubColor.Number == 16){
            cubColor.SetColor(3);
        }
        
        if(cubColor.Number == 32){
            cubColor.SetColor(4);
        }

        if(cubColor.Number == 64){
            cubColor.SetColor(5);
        }

        if(cubColor.Number == 128){
            cubColor.SetColor(6);
        }

        if(cubColor.Number == 256){
            cubColor.SetColor(7);
        }

        if(cubColor.Number == 512){
            cubColor.SetColor(8);
        }
        
        if(cubColor.Number == 1024){
            cubColor.SetColor(9);
        }

    }
    
}
