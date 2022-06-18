using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject rightBound;
    public GameObject leftBound;
    public float speed = 5f;
    public float speedForce = 22f;
    GameObject go;
    
    [SerializeField] private Cubeq cub;
    
    void Start(){
        Spawn();
    }
    
    private void Update() {
        
        Move();
        Shoot();
    }
    void Move(){
        Ray worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        float maxZ = rightBound.transform.position.z;
        float minZ = leftBound.transform.position.z;
        

        float z = worldPosition.direction.z;
        float x = cubePrefab.transform.position.x;
        float y = cubePrefab.transform.position.y;
              
        Vector3 pos = new Vector3(x, y, z * speed);
        
        if(Input.GetMouseButton(0)){
            
            
            if(go.transform.position.z <= maxZ & go.transform.position.z >= minZ){
            go.transform.position = pos;
            }
            if(go.transform.position.z > maxZ){
                
                Vector3 positionZ = new Vector3(x, y, maxZ);
                go.transform.position = positionZ;
            }
            if(go.transform.position.z < minZ){
                
                Vector3 positionZ = new Vector3(x, y, minZ);
                go.transform.position = positionZ;
            }
        }
    }

    void Shoot(){
        if(go != null)
        {
            Rigidbody rb = go.GetComponent<Rigidbody>();
            if(Input.GetMouseButtonUp(0)){
        
                Vector3 add = new Vector3(-10f, go.transform.position.y, go.transform.position.z);
                rb.AddForce(Vector3.left * speedForce, ForceMode.Impulse);
                Invoke("Spawn", 1.0f);
            }       
        }
       
    }
    
    void Spawn(){
        
        
        int rand = Random.Range(0, 10);
        cub.SetNumber(rand);
        go = Instantiate(cubePrefab, new Vector3(4f, 0.91f, 0f), Quaternion.identity);
        
        
        
            
    }
    
}
