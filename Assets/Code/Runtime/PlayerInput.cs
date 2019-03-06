using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Rigidbody2D mRidgidbody;
    public Transform feetPos;

    public float mJumpHight = 5.0f;
    public float mRunSpeed = 2.0f;

    public bool mHasJumpedOnce = false;
    public bool mHasJumpedTwice = false;
    

    void FixedUpdate()
    {
        var hit = Physics2D.Raycast(feetPos.position, Vector2.down, 0.5f);
        if (hit.collider != null)
        {
            Debug.Log("RAycast Hit!");
            mHasJumpedOnce = false;
            mHasJumpedTwice = false;
        }
    }

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
            if (mHasJumpedOnce == false)
            {
                mRidgidbody.AddForce(Vector2.up * mJumpHight, ForceMode2D.Impulse);
                mHasJumpedOnce = true;
            }
            else if (mHasJumpedTwice == false)
            {
                mRidgidbody.AddForce(Vector2.up * mJumpHight * 2, ForceMode2D.Impulse);
                mHasJumpedTwice = true;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 0.5f);
    }
}
