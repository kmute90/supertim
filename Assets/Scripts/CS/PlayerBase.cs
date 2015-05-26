using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class PlayerBase : MonoBehaviour
    {
        #region Private variables

        public Animator anim;

        #endregion

        #region Public fields, editable from Unity

        #endregion

        void Start()
        {
            anim = GetComponent<Animator>();
            anim.Play("Jump");
        }

    }

}




