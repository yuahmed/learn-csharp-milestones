using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;

    public float JumpVelocity = 5f;
    private bool _isJumping;

    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider _col;

    public GameObject Projectile;
    public float ProjSpeed = 100f;
    private bool _isShooting;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        _isJumping |= Input.GetKeyDown(KeyCode.J);
        _isShooting |= Input.GetKeyDown(KeyCode.Space);


        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput *Time.deltaTime);
       
    }

    void FixedUpdate()
    {
        if (_isJumping && IsGrounded())
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;

        if (_isShooting)
        {
            GameObject newProjectile = Instantiate(Projectile, this.transform.position + new Vector3(0, 0, 1), this.transform.rotation);
            Rigidbody projectileRB = newProjectile.GetComponent<Rigidbody>();

            projectileRB.velocity = this.transform.forward * ProjSpeed;
        }

        _isShooting = false;

        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }
}