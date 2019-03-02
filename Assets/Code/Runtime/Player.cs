using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D mRidgidbody;
    public float mJumpHight;

	void Start ()
    {
        mRidgidbody = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            mRidgidbody.AddForce(Vector2.up * mJumpHight, ForceMode2D.Impulse);
        }
    }
}
