using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class FallController : MonoBehaviour
    {
        //public bool isEdge = false;
        //public void OnCollisionEnter2D(Collision2D coll)
        //{
        //    TimController.isFalling = false;

        //    var animator = (Animator)coll.gameObject.GetComponent("Animator");
        //    animator.Play("Idle");
        //}

        //public void OnCollisionExit2D(Collision2D coll)
        //{
        //    if (isEdge)
        //    {
        //        TimController.isFalling = true;
        //        var animator = (Animator)coll.gameObject.GetComponent("Animator");
        //        animator.Play("Jump");
        //    }

        //}

        public void OnTriggerEnter2D(Collider2D coll)
        {
            TimController.IsFalling = true;
            var animator = (Animator)coll.gameObject.GetComponent("Animator");
            animator.Play("Jump");
        }
    }
}

