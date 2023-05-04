using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float currentAngle = 0f;

    public SpriteRenderer tankCharacter;

    public Vector3 moveInput;

	private Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		transform.localScale = new Vector3(-1f, 1f, 1f);
	}

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
		moveInput.x = Input.GetAxis("Horizontal");
		moveInput.y = Input.GetAxis("Vertical");

		transform.position += moveInput * moveSpeed * Time.deltaTime;

        float angle = Mathf.Atan2(moveInput.y, moveInput.x) * Mathf.Rad2Deg;
        if(angle == 180f)
        {
            angle = 0f;
        }

        if(moveInput.x == 0 && moveInput.y == 0) 
        {
            return;
        }

		Quaternion rotation = Quaternion.Euler(0f, 0f, angle - 90);
		transform.rotation = rotation;
        
	}
}
