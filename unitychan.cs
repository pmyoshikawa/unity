using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychan : MonoBehaviour
{
    //public AudioClip sound01;
    //public AudioClip sound02;
    //public AudioClip sound03;

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    float moveSpeed = 3f;

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y);
        //↑を追加する

        if (Time.timeScale == 0)
        {
            return;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(0, GetComponent<Rigidbody>().velocity.y);

        if (Input.GetKey("s"))
        {
            if (Input.GetKey("up"))
            {
                transform.position += transform.forward * 0.03f;
                animator.SetBool("running", true);
      //          GetComponent<AudioSource>().PlayOneShot(sound01);
                

            }
            if (Input.GetKey("down"))
            {
                transform.position += transform.forward * -0.03f;
                animator.SetBool("running", true);
        //        GetComponent<AudioSource>().PlayOneShot(sound01);
              
            }

            if (Input.GetKey("right"))
            {
                transform.Rotate(0, 0.3f, 0);
       //         GetComponent<AudioSource>().PlayOneShot(sound01);
            }
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -0.3f, 0);
       //         GetComponent<AudioSource>().PlayOneShot(sound01);
            }
        }
        else
        {
            if (Input.GetKey("d"))
            {
                if (Input.GetKey("up"))
                {
                    transform.position += transform.forward * 0.09f;
                    animator.SetBool("running", true);
                    //            GetComponent<AudioSource>().PlayOneShot(sound02);

                }
                if (Input.GetKey("down"))
                {
                    transform.position += transform.forward * -0.09f;
                    animator.SetBool("running", true);
                    //            GetComponent<AudioSource>().PlayOneShot(sound02);

                }

                if (Input.GetKey("right"))
                {
                    transform.Rotate(0, 2f, 0);
                    //          GetComponent<AudioSource>().PlayOneShot(sound02);
                }
                if (Input.GetKey("left"))
                {
                    transform.Rotate(0, -2f, 0);
                    //        GetComponent<AudioSource>().PlayOneShot(sound02);
                }
            }
            else
            {
                if (Input.GetKey("v"))
                {
                    if (Input.GetKey("b"))
                    {
                        if (Input.GetKey("up"))
                        {
                            transform.position += transform.forward * 0.8f;
                            animator.SetBool("running", true);
                            //            GetComponent<AudioSource>().PlayOneShot(sound02);

                        }
                        if (Input.GetKey("down"))
                        {
                            transform.position += transform.forward * -0.8f;
                            animator.SetBool("running", true);
                            //            GetComponent<AudioSource>().PlayOneShot(sound02);

                        }

                        if (Input.GetKey("right"))
                        {
                            transform.Rotate(0, 2f, 0);
                            //          GetComponent<AudioSource>().PlayOneShot(sound02);
                        }
                        if (Input.GetKey("left"))
                        {
                            transform.Rotate(0, -2f, 0);
                            //        GetComponent<AudioSource>().PlayOneShot(sound02);
                        }
                    }
                }
            }
                if (Input.GetKey("up"))
                {
                    transform.position += transform.forward * 0.08f;
                    animator.SetBool("running", true);
          //          GetComponent<AudioSource>().PlayOneShot(sound03);
                   

                }
                if (Input.GetKey("down"))
                {
                    transform.position += transform.forward * -0.08f;
                    animator.SetBool("running", true);
            //        GetComponent<AudioSource>().PlayOneShot(sound03);
                   
                }

                if (Input.GetKey("right"))
                {
                    transform.Rotate(0, 1f, 0);
        //            GetComponent<AudioSource>().PlayOneShot(sound03);
                }
                if (Input.GetKey("left"))
                {
                    transform.Rotate(0, -1f, 0);
          //          GetComponent<AudioSource>().PlayOneShot(sound03);
                }
            }

        }
    void Awake () {
	DontDestroyOnLoad(this);
}
    }
