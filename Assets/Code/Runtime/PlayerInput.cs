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
            transform.Translate(Vector3.right * mRunSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * mRunSpeed * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mRidgidbody.AddForce(Vector2.up * mJumpHight, ForceMode2D.Impulse);
        }
    }
}
