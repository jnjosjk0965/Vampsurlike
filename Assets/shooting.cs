using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    public float timeBetweenFiring;
    private float timer;
    private Vector2 scale;
    public Vector3 flipL;
    public Vector3 flipR;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        flipL = flipR = transform.localPosition;
        flipL.x *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if(!canFire ) 
        {
            timer += Time.deltaTime;
            if( timer > timeBetweenFiring ) 
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Input.GetMouseButton(0) && canFire) 
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }

        scale = transform.localScale;

        if (rotation.x < 0)
        {
            scale.y = -1;
            transform.localPosition = flipL;


        } else if (rotation.x > 0)
        {
            scale.y = 1;
            transform.localPosition = flipR;
        }
        transform.localScale = scale;

    }
}
