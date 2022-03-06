using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class manager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        PhotonNetwork.Instantiate(player.name, spawnPoint.position, spawnPoint.rotation);
    }
}
