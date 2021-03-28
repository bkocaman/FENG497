using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public ScoreManager scoreManager;
	public GameObject Player;
	private  Slider slide;

	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 650f;
	public float bounceFactor = 1.25f;
	public float forceJumpLimit = 1700f;
	public float HorizontalJumpFactor = 100f;

	private Rigidbody2D rb2D;
	private Animation anim;

	public ParticleSystem forceJumpEffect;
	public ParticleSystem moveParticle;

	private float velocity;
	private float h;

	private void Start()
	{
		forceJumpEffect.Stop(); // Initially stop The Animation //
		moveParticle.Stop();
		anim = this.transform.GetChild(1).GetComponent<Animation>();
		anim.wrapMode = WrapMode.Once;
		rb2D = GetComponent<Rigidbody2D>();
		InitializeSlider();
	}
	private void InitializeSlider()
    {
		slide = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
		slide.minValue = 0;
		slide.maxValue = 100;
		slide.wholeNumbers = true;
		slide.value = 5;
	}

	private void Update()
    {
		velocity = rb2D.velocity.y;
	}

	private void Move()
    {
		h = Input.GetAxis("Horizontal");

		if (Mathf.Abs(h * rb2D.velocity.x) < maxSpeed)
		{
			rb2D.AddForce(h * moveForce * Vector2.right);
		}

		if (Mathf.Abs(h) <= 0.05)
		{
			rb2D.velocity = new Vector2(0, rb2D.velocity.y);
		}
	}

	private void JumpControl()
    {
		if (velocity == 0)
		{
			Jump();
			anim.Play();
		}
		else if (velocity < 0)
		{
			forceJumpEffect.Stop();
			moveParticle.Stop();
		}
	}

	private void FixedUpdate()
	{
		Move();
		JumpControl();
	}

	void Jump()
	{
		if(slide.value == 100)
        {
			rb2D.AddForce(Vector2.up * ((jumpForce * 3) + Mathf.Abs(rb2D.velocity.y) * HorizontalJumpFactor));
			slide.value = 0;
			moveParticle.Stop();
			forceJumpEffect.Play();
		}
		else
        {
			rb2D.AddForce(Vector2.up * (jumpForce + Mathf.Abs(rb2D.velocity.y) * HorizontalJumpFactor));
			//SliderUpdate(10);
			forceJumpEffect.Stop();
			moveParticle.Play();
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{


		if (collision.gameObject.tag == "coin")
		{
			Destroy(collision.gameObject);
			ScoreManager.coin++;
		}
	}

	private void SliderUpdate(int value)
    {
		slide.value += value;
    }
}
