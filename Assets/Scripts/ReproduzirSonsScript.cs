using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproduzirSonsScript : MonoBehaviour
{
    //---------------------------------------------------VARI�VEIS------------------------------------------------------------------------------
    public AudioSource somWC;
//------------------------------------------------------------------------------------------------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReproduzirSomWC()
    {
        //reproduz o AudioSource
        somWC.Play();
    }
}
