using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float RunSpeed;
    public Transform Gun;
    public GameObject Bullet;
    public float BulletSpeed;
    public Transform ShootPoint;
    public GameObject Grab1;
    public GameObject Grab2;
    Vector2 direction;
    void Start(){
        body = GetComponent<Rigidbody2D>();
    }
    void Update(){
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)transform.position;
        transform.right = direction;
        if (Input.GetMouseButtonDown(0)){
            GameObject BulletInstantiate = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
            BulletInstantiate.GetComponent<Rigidbody2D>().AddForce(BulletInstantiate.transform.right * BulletSpeed);
        }
        if (Input.GetMouseButtonDown(1)){
            Grab1.SetActive(true);
            Grab2.SetActive(true);
        }else if (Input.GetMouseButtonUp(1)){
            Grab1.SetActive(false);
            Grab2.SetActive(false);
        }
    }
    private void FixedUpdate(){
        body.velocity = new Vector2(horizontal * RunSpeed, vertical * RunSpeed);
    }
}