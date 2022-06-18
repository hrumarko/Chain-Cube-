using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    [SerializeField] private Cube cuba;
    // [SerializeField] private Cubeq newCuba;
    public GameObject prefab;
    GameObject cube;
    bool destroy;
    public float force;
    
    private void Awake() {
        cuba = GetComponent<Cube>();    
    }
    

    private void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.tag == "Lose"){
            Debug.Log("lossssssss");
        }
        Cube otherCube = collision.gameObject.GetComponent<Cube>();
        if(otherCube != null){
            if(cuba.Number == otherCube.Number){
                int num = cuba.Number + otherCube.Number;
                Vector3 pos = otherCube.gameObject.transform.position;                
                Destroy(collision.gameObject);
                cuba.SetNumber(num);
                Rigidbody rb = cuba.GetComponent<Rigidbody>();
                rb.AddForce(Vector3.up* force, ForceMode.Impulse);
                
                
            }
            
        }
        
    }
   
}
