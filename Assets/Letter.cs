using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour{
    public GameObject GrabHelper;
    public GameObject LetterPlace;
    public GameObject LetterPlace2;
    public GameObject LetterPlace3;
    private int x;
    void Start(){
        
    }
    void Update(){
        if (x == 1){
            transform.position = (Vector3)GrabHelper.transform.position;
            transform.rotation = GrabHelper.transform.rotation;
        }
        if (GrabHelper.activeInHierarchy == false){
            x = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 7 && GrabHelper.activeInHierarchy == true){
            x = 1;
        }if (other.gameObject.layer == 8){
            x = 0;
            transform.position = (Vector3)LetterPlace.transform.position;
            transform.rotation = LetterPlace.transform.rotation;
        }if (other.gameObject.layer == 9){
            x = 0;
            transform.position = (Vector3)LetterPlace2.transform.position;
            transform.rotation = LetterPlace2.transform.rotation;
        }if (other.gameObject.layer == 10){
            x = 0;
            transform.position = (Vector3)LetterPlace3.transform.position;
            transform.rotation = LetterPlace3.transform.rotation;
        }
    }
}
