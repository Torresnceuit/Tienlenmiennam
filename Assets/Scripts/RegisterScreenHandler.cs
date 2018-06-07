using Sfs2X;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterScreenHandler : MonoBehaviour {

    //----------------------------------------------------------
    // Editor public properties
    //----------------------------------------------------------

    [Tooltip("IP address or domain name of the SmartFoxServer 2X instance")]
    public string Host = "127.0.0.1";

    [Tooltip("TCP port listened by the SmartFoxServer 2X instance")]
    public int TcpPort = 9933;

    [Tooltip("UDP port listened by the SmartFoxServer 2X instance")]
    public int UdpPort = 9933;

    [Tooltip("Name of the SmartFoxServer 2X Zone to join")]
    public string Zone = "BasicExamples";

    //----------------------------------------------------------
    // UI elements
    //----------------------------------------------------------

    public InputField nameInput;
    public InputField passInput;
    public InputField confirmInput;
    public InputField emailInput;

    //----------------------------------------------------------
    // Private properties
    //----------------------------------------------------------

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
