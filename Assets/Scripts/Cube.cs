using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    
    public GameObject cube;
    
    
    public TextMeshProUGUI textOn;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            
            textOn.text = "8";
        }
    }

    
    
    
    
}
