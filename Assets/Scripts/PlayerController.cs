using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CECI EST L'AJOUT D'UNE LIGNE DE CODE

public class PlayerController : MonoBehaviour
{
    //Player Elements
    public Rigidbody _rb;

    //Player features
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    //Fire part
    public GameObject _bullet;
    public Transform _firePoint;


    // Update is called once per frame
    void Update()
    {
        PlayerOrientation();

    }

    private void FixedUpdate()
    {
        PlayerMovement();

    }

    public void PlayerMovement()
    {
        Vector3 inputs = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (inputs.sqrMagnitude < 1)
        {
            inputs.Normalize();
        }

        _rb.velocity = inputs * _speed;
    }

    public void PlayerOrientation()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction * 50, Color.red);

        RaycastHit hitInfos;

        if(Physics.Raycast(ray, out hitInfos))
        {
        Vector3 pos = new Vector3(hitInfos.point.x, transform.position.y, hitInfos.point.z);


        transform.LookAt(pos);
        }

       


    }
    

}
