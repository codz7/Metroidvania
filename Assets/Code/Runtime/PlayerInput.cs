using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Rigidbody2D mRidgidbody;

    public float mJumpHight = 5.0f;
    public float mRunSpeed = 2.0f;

    void Start ()
    {
        mRidgidbody = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * mRunSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * mRunSpeed * Time.deltaTime);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            mRidgidbody.AddForce(Vector2.up * mJumpHight, ForceMode2D.Impulse);
        }
    }
}
