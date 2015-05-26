using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class TrambulinCollideManager : MonoBehaviour
    {

        public float trambulinPower = 100.0f;

        public void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "Player")
            {
                var timController = coll.gameObject.GetComponent("TimController");
                TimController.IsFalling = true;
                timController.rigidbody2D.AddForce(Vector2.up * (TimController.jumpForce + trambulinPower));

                var amimator = (Animator) coll.gameObject.GetComponent("Animator");
                amimator.Play("Jump");

                //coll.gameObject.jumpForce += 200;
            }
        }
    }
}