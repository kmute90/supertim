using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
	public class TimController : PlayerBase
	{
	    public static float jumpForce = 300.0f;

	    public float Speed
	    {
	        get
	        {
	            switch (GameMaster.currentLevel)
	            {
	                case 1:
	                    return 2;
                    case 2:
	                    return 2.1f;
                    case 3:
	                    return 2.2f;
                    default:
	                    return 2;
	            }
	        }
	    }

        private static bool isFalling = true;
        public static bool IsFalling
        {
            get { return isFalling; }
            set { isFalling = value; }
        }
        
        public int maxFallDistance = -5;

	    

	    public AudioClip MonsterScream;

		void Update()
		{
            Move();
            if (transform.position.y <= maxFallDistance)
            {
                GameMaster.InitLevel();
            }
		}

		public void Move()
		{
            if (Input.GetKeyDown(KeyCode.Mouse0) && IsFalling == false)
			{
                IsFalling = true;

				rigidbody2D.AddForce(Vector2.up * jumpForce);

			    var amimator = (Animator)GetComponent("Animator");
                amimator.Play("Jump");
			}
			
			transform.Translate(Vector3.right * Speed * Time.deltaTime);
		}


	}
}
