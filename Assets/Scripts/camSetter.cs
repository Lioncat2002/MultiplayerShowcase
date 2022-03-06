using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

using TMPro;
public class camSetter : MonoBehaviourPunCallbacks
{
    public GameObject cam;
    public GameObject cineCam;
    public TextMeshProUGUI nameTagTxt;
    // Start is called before the first frame update
    void Awake()
    {
        
        if (!photonView.IsMine)
        {
            
            cam.SetActive(false);
            cineCam.SetActive(false);
            nameTagTxt.text = photonView.Owner.NickName;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
