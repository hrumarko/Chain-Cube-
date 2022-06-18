using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
    [SerializeField] private Cubeq cuba;
    // [SerializeField] private Cubeq newCuba;
    GameObject newCub;

    private void Awake() {
        cuba = GetComponent<Cubeq>();    
    }

    private void OnCollisionEnter(Collision collision) {
        Cubeq otherCube = collision.gameObject.GetComponent<Cubeq>();
        if(otherCube != null){
            if(cuba.Number == otherCube.Number){
                Destroy(cuba.gameObject);
                Destroy(otherCube.gameObject);
                Vector3 contactPoint = cuba.gameObject.transform.position;
                Debug.Log(contactPoint);                
                int num = cuba.Number + otherCube.Number;
                cuba.SetNumber(num);
                newCub = Instantiate(cuba.gameObject, contactPoint, Quaternion.identity);
                
                
            }
        }
    }
}
