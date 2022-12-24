using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour{
    public GameObject GrabHelper;
    private bool IsGrab = false;
    public static bool IsGrab1 = false;
    public float movementRange;
    private Vector3 desiredPos;
    public float speed;
    private bool isGotShoot = false;
    public static bool isGotShoot1 = true;
    private bool isMoving;
    public float minDistance;
    public Transform topleft;
    public Transform bottomright;
    private bool inPlace;
    Rigidbody2D m_Rigidbody;

    void Start(){
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }void Update(){
        StartCoroutine(Move());
        if (IsGrab1 == false){
            IsGrab = false;
        }if (IsGrab == true && isGotShoot == true){
            transform.position = (Vector3)GrabHelper.transform.position;
            transform.rotation = GrabHelper.transform.rotation;
            m_Rigidbody.constraints = RigidbodyConstraints2D.None;
        }else{
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        }if (GrabHelper.activeInHierarchy == false){
            IsGrab = false;
        }if (isGotShoot1 == false){
            isGotShoot = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 7 && GrabHelper.activeInHierarchy == true){
            IsGrab = true;
            IsGrab1 = true;
        }if (other.gameObject.layer == 9){
            StartCoroutine(GotShot());
        }
        if(other.gameObject.layer == 8)
        {
            inPlace = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 12)
        {
            inPlace = false;
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
            yield return new WaitForSeconds(0);
            isMoving = false;
        }
    }

    private IEnumerator GotShot()
    {
        isGotShoot = true;
        yield return new WaitForSeconds(5);
        if(!inPlace)
        {
            isGotShoot = false;
        }
    }
}
