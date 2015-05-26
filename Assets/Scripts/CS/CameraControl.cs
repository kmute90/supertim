using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.CS
{
    public class CameraControl : MonoBehaviour
    {
        public Transform Target;
        public int distance = -10;
        public double lift = 1.5;
        
        public void Update()
        {
            transform.position = Target.position + new Vector3(0, 0, distance);

            transform.LookAt(Target);
        }
    }

}
