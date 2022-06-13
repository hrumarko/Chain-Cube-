using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControk : MonoBehaviour, ICube
{
    public GameObject cube;
    public GameObject cubeOutside;
    public GameObject player;
    public GameObject rightBound;
    public GameObject leftBound;
    public float speed = 10f;
    public float speedForce = 50f;
    
   
    GameObject cubePrefab;
    
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        
        cubePrefab = Instantiate(cube, new Vector3(4, 0.91f, 0), Quaternion.identity);
        cubePrefab.transform.parent = player.transform;
        float maxZ = rightBound.transform.position.z;
        float minZ = leftBound.transform.position.z;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(cubePrefab.transform.parent == player.transform){
        Move();
        Shoot();
        }
        
        
        

    }
    public void Move(){
       
        Ray worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        float maxZ = rightBound.transform.position.z;
        float minZ = leftBound.transform.position.z;
        

        float z = worldPosition.direction.z;
        float x = cubePrefab.transform.position.x;
        float y = cubePrefab.transform.position.y;
              
        Vector3 pos = new Vector3(x, y, z * speed);
        
        if(Input.GetMouseButton(0)){
            
            
            if(cubePrefab.transform.position.z <= maxZ & cubePrefab.transform.position.z >= minZ){
            cubePrefab.transform.position = pos;
            }
            if(cubePrefab.transform.position.z > maxZ){
                
                Vector3 positionZ = new Vector3(x, y, maxZ);
                cubePrefab.transform.position = positionZ;
            }
            if(cubePrefab.transform.position.z < minZ){
                
                Vector3 positionZ = new Vector3(x, y, minZ);
                cubePrefab.transform.position = positionZ;
            }
        }
        
        
    }
    public void Shoot(){
        rb = cubePrefab.GetComponent<Rigidbody>();
       if(Input.GetMouseButtonUp(0)){
        Vector3 add = new Vector3(-10f, cubePrefab.transform.position.y, cubePrefab.transform.position.z);
        rb.AddForce(Vector3.left * speedForce, ForceMode.Impulse);
        cubePrefab.transform.parent = cubeOutside.transform;
        
        Invoke("SpawnCubes", 1.0f);
    }
    
    
    }
    public void SpawnCubes()
    {
        cubePrefab = Instantiate(cube, new Vector3(4, 0.91f, 0), Quaternion.identity);
        cubePrefab.transform.parent = player.transform;
    }
}
