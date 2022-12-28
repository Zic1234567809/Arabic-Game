using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceForLerrer : MonoBehaviour{
    public static string LetterIn1 = "-";
    public static string LetterIn2 = "-";
    public static string LetterIn3 = "-";
    public static string LetterIn4 = "-";
    public static string LetterIn5 = "-";
    public static string LetterIn6 = "-";
    public static string LetterIn7 = "-";
    public static string LetterIn8 = "-";
    public static string LetterIn9 = "-";
    public static string LetterIn10 = "-";
    void Start(){
        
    }void Update(){
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 6){
            Letter.IsGrab1 = false;
            other.gameObject.transform.position = (Vector3)transform.position;
            other.gameObject.transform.rotation = transform.rotation;
            if (gameObject.name == "ampty1"){
                LetterIn1 = other.gameObject.name;
            }if (gameObject.name == "ampty2"){
                LetterIn2 = other.gameObject.name;
            }if (gameObject.name == "ampty3"){
                LetterIn3 = other.gameObject.name;
            }if (gameObject.name == "ampty4"){
                LetterIn4 = other.gameObject.name;
            }if (gameObject.name == "ampty5"){
                LetterIn5 = other.gameObject.name;
            }if (gameObject.name == "ampty6"){
                LetterIn6 = other.gameObject.name;
            }if (gameObject.name == "ampty7"){
                LetterIn7 = other.gameObject.name;
            }if (gameObject.name == "ampty8"){
                LetterIn8 = other.gameObject.name;
            }if (gameObject.name == "ampty9"){
                LetterIn9 = other.gameObject.name;
            }if (gameObject.name == "ampty10"){
                LetterIn10 = other.gameObject.name;
            }
        }
    }private void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.layer == 6){
            if (gameObject.name == "ampty1"){
                LetterIn1 = "-";
            }if (gameObject.name == "ampty2"){
                LetterIn2 = "-";
            }if (gameObject.name == "ampty3"){
                LetterIn3 = "-";
            }if (gameObject.name == "ampty4"){
                LetterIn4 = "-";
            }if (gameObject.name == "ampty5"){
                LetterIn5 = "-";
            }if (gameObject.name == "ampty6"){
                LetterIn6 = "-";
            }if (gameObject.name == "ampty7"){
                LetterIn7 = "-";
            }if (gameObject.name == "ampty8"){
                LetterIn8 = "-";
            }if (gameObject.name == "ampty9"){
                LetterIn9 = "-";
            }if (gameObject.name == "ampty10"){
                LetterIn10 = "-";
            }
        }
    }
}
