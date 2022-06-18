using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    // public GameObject player; 
    // GameObject cubePrefab;
    // public GameObject rightBound;
    // public GameObject leftBound;
    // public float speed = 5f;
    // public float speedForce = 22f;
    // public GameObject cubeOutside;
    // public bool isMain;
   
    // Cube cubePref;
    // private void Start() {
    //     cubePref = GetComponent<Cube>();
    //     Spawn();
    // }
    // private void Update() {
    //     Move();
    //     Shoot();
    // }

    // public void Move(){
    //     Ray worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     float maxZ = rightBound.transform.position.z;
    //     float minZ = leftBound.transform.position.z;
        

    //     float z = worldPosition.direction.z;
    //     float x = cubePrefab.transform.position.x;
    //     float y = cubePrefab.transform.position.y;
              
    //     Vector3 pos = new Vector3(x, y, z * speed);
        
    //     if(Input.GetMouseButton(0)&& cubePrefab.transform.parent == player.transform){
            
    //         cubePref.isMain = true;
    //         if(cubePrefab.transform.position.z <= maxZ & cubePrefab.transform.position.z >= minZ){
    //         cubePrefab.transform.position = pos;
    //         }
    //         if(cubePrefab.transform.position.z > maxZ){
                
    //             Vector3 positionZ = new Vector3(x, y, maxZ);
    //             cubePrefab.transform.position = positionZ;
    //         }
    //         if(cubePrefab.transform.position.z < minZ){
                
    //             Vector3 positionZ = new Vector3(x, y, minZ);
    //             cubePrefab.transform.position = positionZ;
    //         }
    //     }
    // }

    // public void Shoot(){
    //     Rigidbody rb = cubePrefab.GetComponent<Rigidbody>();
    //    if(Input.GetMouseButtonUp(0)&& cubePrefab.transform.parent == player.transform){
    //     Vector3 add = new Vector3(-10f, cubePrefab.transform.position.y, cubePrefab.transform.position.z);
    //     rb.AddForce(Vector3.left * speedForce, ForceMode.Impulse);
    //     cubePrefab.transform.parent = cubeOutside.transform;
    //     cubePref.isMain = false;
        
    //     Invoke("Spawn", 1.0f);
    // }
    // }
    // public void Spawn(){
    //     int rand = Random.Range(0, 4);
    //     cubePref.SetColor(rand);
    //     cubePref.SetNumber(cubePref.nums[rand]);
    //     //cubePrefab = Instantiate(cubePref.cubePrefab, new Vector3(4, 0.91f, 0), Quaternion.identity);
        
    //     cubePrefab.transform.parent = player.transform;
    // }
    

    

    
}
