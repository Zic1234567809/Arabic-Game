using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float RunSpeed;
    public GameObject Gun;
    public GameObject Bullet;
    public float BulletSpeed;
    public float bulletCooldown;
    float bulletCountdown;
    public GameObject ShootPoint;
    public GameObject Grab1;
    public GameObject Grab2;
    public GameObject GrabHelper;
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
        if (Input.GetMouseButtonDown(0) && bulletCountdown <= 0 && Gun.activeInHierarchy == true){
            GameObject BulletInstantiate = Instantiate(Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);
            BulletInstantiate.GetComponent<Rigidbody2D>().AddForce(BulletInstantiate.transform.right * BulletSpeed);
            bulletCountdown = bulletCooldown;
        }
        if (Input.GetMouseButtonDown(1)){
            Grab1.SetActive(true);
            Grab2.SetActive(true);
            GrabHelper.SetActive(true);
            Gun.SetActive(false);
        }else if (Input.GetMouseButtonUp(1)){
            Grab1.SetActive(false);
            Grab2.SetActive(false);
            GrabHelper.SetActive(false);
            Gun.SetActive(true);
        }
        bulletCountdown -= Time.deltaTime;
    }
    private void FixedUpdate(){
        body.velocity = new Vector2(horizontal * RunSpeed, vertical * RunSpeed);
    }
}