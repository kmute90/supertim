using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.CS
{
    public class GroundController : MonoBehaviour
    {
        public void OnCollisionEnter2D(Collision2D coll)
        {
            TimController.IsFalling = false;

            var animator = (Animator)coll.gameObject.GetComponent("Animator");
            animator.Play("Idle");
        }

    }
}
