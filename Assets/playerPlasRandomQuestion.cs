using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class playerPlasRandomQuestion : MonoBehaviour{
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
    public GameObject LetterPlace1;
    public GameObject LetterPlace2;
    public GameObject LetterPlace3;
    public GameObject LetterPlace4;
    public GameObject LetterPlace5;
    public GameObject LetterPlace6;
    public GameObject LetterPlace7;
    public GameObject LetterPlace8;
    public GameObject LetterPlace9;
    public GameObject LetterPlace10;
    public List<string> spawnpool = new List<string>();
    public List<int> intList = new List<int>();
    public InsideList listInsideList = new InsideList();
    public TextMeshProUGUI QText;
    private int randomItem;
    Vector2 direction;
    void Start() {
        body = GetComponent<Rigidbody2D>();
        randomItem = Random.Range(0, spawnpool.Count);
        QText.text = spawnpool[randomItem];
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
        if (intList[randomItem] < 1) {
            LetterPlace1.SetActive(false);
        } else {
            LetterPlace1.SetActive(true);
        } if (intList[randomItem] < 2) {
            LetterPlace2.SetActive(false);
        } else {
            LetterPlace2.SetActive(true);
        } if (intList[randomItem] < 3) {
            LetterPlace3.SetActive(false);
        } else {
            LetterPlace3.SetActive(true);
        } if (intList[randomItem] < 4) {
            LetterPlace4.SetActive(false);
        } else {
            LetterPlace4.SetActive(true);
        } if (intList[randomItem] < 5) {
            LetterPlace5.SetActive(false);
        } else {
            LetterPlace5.SetActive(true);
        } if (intList[randomItem] < 6) {
            LetterPlace6.SetActive(false);
        } else {
            LetterPlace6.SetActive(true);
        } if (intList[randomItem] < 7) {
            LetterPlace7.SetActive(false);
        } else {
            LetterPlace7.SetActive(true);
        } if (intList[randomItem] < 8) {
            LetterPlace8.SetActive(false);
        } else {
            LetterPlace8.SetActive(true);
        } if (intList[randomItem] < 9) {
            LetterPlace9.SetActive(false);
        } else {
            LetterPlace9.SetActive(true);
        } if (intList[randomItem] < 10) {
            LetterPlace10.SetActive(false);
        } else {
            LetterPlace10.SetActive(true);
        }
        if (PlaceForLerrer.LetterIn1 == listInsideList.list[randomItem].list[0] && PlaceForLerrer.LetterIn2 == listInsideList.list[randomItem].list[1] && PlaceForLerrer.LetterIn3 == listInsideList.list[randomItem].list[2] && PlaceForLerrer.LetterIn4 == listInsideList.list[randomItem].list[3] && PlaceForLerrer.LetterIn5 == listInsideList.list[randomItem].list[4] && PlaceForLerrer.LetterIn6 == listInsideList.list[randomItem].list[5] && PlaceForLerrer.LetterIn7 == listInsideList.list[randomItem].list[6] && PlaceForLerrer.LetterIn8 == listInsideList.list[randomItem].list[7]){
            spawnpool.Remove(spawnpool[randomItem]);
            intList.Remove(intList[randomItem]);
            Debug.Log(spawnpool.Count);
            if (spawnpool.Count == 0){
                SceneManager.LoadScene(0);
            }
            listInsideList.list.Remove(listInsideList.list[randomItem]);
            randomItem = Random.Range(0, spawnpool.Count);
            QText.text = spawnpool[randomItem];
            Letter.isGotShoot1 = false;
        }
    }
    private void FixedUpdate(){
        body.velocity = new Vector2(horizontal * RunSpeed, vertical * RunSpeed);
    }
}