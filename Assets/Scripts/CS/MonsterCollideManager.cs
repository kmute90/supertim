using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

namespace Assets.Scripts.CS
{
    public class MonsterCollideManager : MonoBehaviour
    {
        public int monsterValue = 1;

        public void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag == "Player")
            {
                MonsterHit(coll.gameObject, transform.parent.gameObject);
            }
        }

        public void MonsterHit(GameObject player, GameObject monster)
        {
            GameMaster.currentLife -= monsterValue;
            if (GameMaster.currentLife <= 0)
            {
                GameMaster.InitLevel();
            }

            var scream = ((TimController)player.GetComponent("TimController")).MonsterScream;
            player.audio.PlayOneShot(scream, 1);

            
            StartCoroutine(AnimateMonster(monster));

            StartCoroutine(AnimatePlayer(player));


        }

        private IEnumerator AnimateMonster(GameObject monster)
        {
            var animator = (Animator) monster.GetComponent("Animator");
            animator.Play("MonsterDie");

            //This is a coroutine
            yield return new WaitForSeconds(2);


            //object the script is sitting on -> destroy
            Destroy(monster);

        }

        private IEnumerator AnimatePlayer(GameObject player)
        {
            var animator = (Animator) player.GetComponent("Animator");
            animator.Play("MonsterHit");

            yield return new WaitForSeconds(1);
        }

    }
}