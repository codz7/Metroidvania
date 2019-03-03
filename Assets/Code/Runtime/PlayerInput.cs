using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Rigidbody2D mRidgidbody;

    public float mJumpHight = 5.0f;
    public float mRunSpeed = 2.0f;
    
	void Update ()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            mRidgidbody.transform.Translate(Vector3.right * mRunSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            mRidgidbody.transform.Translate(Vector3.left * mRunSpeed * -Input.GetAxis("Horizontal") * Time.deltaTime);
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            mRidgidbody.AddForce(Vector2.up * mJumpHight, ForceMode2D.Impulse);
        }
    }
}
