using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kachujin_Control : MonoBehaviour
{
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            _animator.SetTrigger("Kick");
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            _animator.SetTrigger("Punch");
        }
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            _animator.SetBool("Dancing", true);
        }
        else if(Input.GetKeyUp(KeyCode.LeftAlt))
        {
            _animator.SetBool("Dancing", false);
        }
    }
}
