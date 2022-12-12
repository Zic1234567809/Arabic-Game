using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour{
    public GameObject GrabHelper;
    public int x;
    public static int y;
    public float movementRange;
    private Vector3 desiredPos;
    public float speed;
    private bool isGotShoot = false;
    private bool isMoving;
    public float minDistance;
    public Transform topleft;
    public Transform bottomright;

    void Update(){
        StartCoroutine(Move());
        if (y == 0){
            x = 0;
        }if (x == 1 && isGotShoot == true){
            transform.position = (Vector3)GrabHelper.transform.position;
            transform.rotation = GrabHelper.transform.rotation;
        }if (GrabHelper.activeInHierarchy == false){
            x = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 7 && GrabHelper.activeInHierarchy == true){
            x = 1;
            y = 1;
        }if (other.gameObject.layer == 9){
            isGotShoot = true;
        }
    }

    private IEnumerator Move(){
        if(!isMoving){
            isMoving = true;
            while(true){
                desiredPos = new Vector3(Random.Range(-movementRange,movementRange), Random.Range(-movementRange,movementRange), 0) + transform.position;
                if(topleft.position.x < desiredPos.x && desiredPos.x < bottomright.position.x && bottomright.position.y < desiredPos.y && desiredPos.y < topleft.position.y
                 && Vector3.Distance(transform.position, desiredPos) > minDistance)
                    break;
            }
        }
        if (isGotShoot == false){
            transform.position = Vector3.MoveTowards(transform.position, desiredPos, speed * Time.deltaTime);
        }if(Vector3.Distance(transform.position, desiredPos) < 1){
            yield return new WaitForSeconds(1);
            isMoving = false;
        }
    }
}
