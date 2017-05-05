using UnityEngine;
using System.Collections;

public class SimpleMoveControl : MonoBehaviour
{


	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float rotateSpeed = 10f;
	public float gravity = 20.0F;
	private float MOVE_TIME = 0.5f;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	private float m_fMove;
	private float m_fSlide;
	private bool m_bRotation;
	// Use this for initialization
	void Start()
	{
		controller = GetComponent<CharacterController>();
		m_bRotation = false;
	}

	// Update is called once per frame
	void Update()
	{
		//CameraAxisControl();
		if (m_bRotation == false)
		{
			NormalControl();
		}
		jumpControl();
		attachMove();
		//attachRotation();
	}

	public void GoForward( float _fValue)
	{
		Debug.LogError("GoForward");
		iTween.ValueTo(gameObject, iTween.Hash(
			"time", MOVE_TIME, "from" , MOVE_TIME, "to" , MOVE_TIME, 
			"onupdate", "OnUpdateForward", "oncomplete", "OnForwardEnd", "oncompletetarget", gameObject));
		m_fMove = _fValue;
	}
	private void OnUpdateForward()
	{
	}
	private void OnForwardEnd()
	{
		m_fMove = 0.0f;
	}
	public void GoSlide(float _fValue)
	{
		iTween.ValueTo(gameObject, iTween.Hash(
			"time", MOVE_TIME, "from", MOVE_TIME, "to", MOVE_TIME,
			"onupdate", "OnUpdateSlide", "oncomplete", "OnSlideEnd", "oncompletetarget", gameObject));
		m_fSlide = _fValue;
	}
	private void OnUpdateSlide()
	{
	}
	private void OnSlideEnd()
	{
		m_fSlide = 0.0f;
	}

	public void TurnLeft()
	{
		m_bRotation = true;
		iTween.RotateAdd(gameObject, iTween.Hash("time", 0.5, "y", -90, "islocal", true, "oncomplete", "OnRotateEnd", "oncompletetarget", gameObject));

	}

	public void TurnRight()
	{
		m_bRotation = true;
		iTween.RotateAdd(gameObject, iTween.Hash("time", 0.5, "y", 90, "islocal", true, "oncomplete", "OnRotateEnd", "oncompletetarget", gameObject));

	}

	private void OnRotateEnd()
	{
		m_bRotation = false;
	}

	//標準的なコントロール
	void NormalControl()
	{
		if (controller.isGrounded)
		{
			moveDirection = Vector3.zero;
			if (Input.GetAxis("Horizontal")<0)
			{
				TurnLeft();
			}
			else if(0 < Input.GetAxis("Horizontal"))
			{
				TurnRight();
			}
			else if(Input.GetAxis("Vertical") < 0)
			{
				moveDirection = gameObject.transform.forward *-1.0f;
			}
			else if( 0 < Input.GetAxis("Vertical"))
			{
				moveDirection = gameObject.transform.forward * 1.0f;
			}
			else if(m_fMove != 0.0f)
			{
				moveDirection = gameObject.transform.forward * m_fMove;
			}
			else if(m_fSlide != 0.0f)
			{
				moveDirection = gameObject.transform.right * m_fSlide;
			}
			else
			{

			}
			moveDirection *= speed;
		}
		//m_fMove = 0.0f;
		//m_fSlide = 0.0f;
	}

	//カメラ軸に沿った移動コントロール
	void CameraAxisControl()
	{
		if (controller.isGrounded)
		{
			Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
			Vector3 right = Camera.main.transform.TransformDirection(Vector3.right);

			moveDirection = Input.GetAxis("Horizontal") * right + Input.GetAxis("Vertical") * forward;
			moveDirection *= speed;
		}
	}

	//標準的なジャンプコントロール
	void jumpControl()
	{
		if (Input.GetButton("Jump"))
			moveDirection.y = jumpSpeed;
	}

	//移動処理 
	void attachMove()
	{
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	//キャラクターを進行方向へ向ける処理 
	void attachRotation()
	{
		var moveDirectionYzero = -moveDirection;
		moveDirectionYzero.y = 0;

		//ベクトルの２乗の長さを返しそれが0.001以上なら方向を変える（０に近い数字なら方向を変えない） 
		if (moveDirectionYzero.sqrMagnitude > 0.001)
		{

			//２点の角度をなだらかに繋げながら回転していく処理（stepがその変化するスピード） 
			float step = rotateSpeed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, moveDirectionYzero, step, 0f);

			transform.rotation = Quaternion.LookRotation(newDir);
		}
	}
}
