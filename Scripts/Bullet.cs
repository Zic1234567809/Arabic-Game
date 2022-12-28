using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start(){
        
    }
    void Update(){
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 3 || other.gameObject.layer == 6){
            Destroy(gameObject);
        }
    }
}