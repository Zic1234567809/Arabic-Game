using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceForLerrer : MonoBehaviour{
    public GameObject Letter1;
    void Start(){
        
    }void Update(){
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 6){
            Letter.x = 0;
            Letter1.transform.position = (Vector3)transform.position;
            Letter1.transform.rotation = transform.rotation;
        }
    }
}
