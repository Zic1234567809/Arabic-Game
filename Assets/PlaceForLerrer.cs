using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceForLerrer : MonoBehaviour{
    void Start(){
        
    }void Update(){
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 6){
            Letter.y = 0;
            other.gameObject.transform.position = (Vector3)transform.position;
            other.gameObject.transform.rotation = transform.rotation;
        }
    }
}
