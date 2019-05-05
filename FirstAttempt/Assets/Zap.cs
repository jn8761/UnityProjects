using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zap : MonoBehaviour
{
    public class WaitForSecondsTest : MonoBehaviour
    {
        public void Start()
        {
            StartCoroutine(Example());
        }

        IEnumerator Example()
        {
            print(Time.time);
            yield return new WaitForSeconds(5);
            print(Time.time);
        }
    }

    // Start is called before the first frame update
    public Transform player;
    public Rigidbody rb;
    public Vector3 Explosion;
    public AudioClip explodeSound;
    public AudioSource explodeSoundSource;


    bool zapPresent = false;

    //if you enter the zappper, it explodes the player and plays a sound

    public void OnTriggerEnter(Collider other)
    {
        rb.AddExplosionForce(200f, Explosion, 2f);
        explodeSoundSource.clip = explodeSound;
    }

    void Start()
    {
        zapPresent = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (zapPresent == false)
        {
            WaitForSecondsTest temp = new WaitForSecondsTest();
            temp.Start();


        }
    }
}
