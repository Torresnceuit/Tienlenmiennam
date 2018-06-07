using Sfs2X;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterScreenHandler : MonoBehaviour {

    //Private properties
    private SmartFox sfs;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
