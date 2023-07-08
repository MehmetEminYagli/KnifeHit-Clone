using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeController : MonoBehaviour
{
    private KnifeManager knifeManager;

    private Rigidbody2D rb;

    [SerializeField] private float MoveSpeed;

    private bool isShoot;


    


    void Start()
    {
        GetComponentValues();
    }


    private void GetComponentValues()
    {
        rb = GetComponent<Rigidbody2D>();
        knifeManager = FindObjectOfType<KnifeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootInput();
    }

    private void FixedUpdate()
    {
        Shoot();
    }

    private void ShootInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knifeManager.setdisableIcon();
            isShoot = true;
        }
            
    }

    private void Shoot()
    {
        if (isShoot)
        {
            rb.AddForce(Vector2.up * MoveSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            knifeManager.SetactiveKnife();
          
            isShoot = false;
            rb.isKinematic = true;
            transform.SetParent(collision.gameObject.transform);
        }

        if (collision.gameObject.CompareTag("Knife"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
