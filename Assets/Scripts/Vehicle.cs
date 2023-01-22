using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject mycar;
    public GameObject myyacht;
    public GameObject areacar;
    public GameObject areayacht;
    public GameObject playerStickMan;
    public GameObject player;
    public GameObject playerStash;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Yacht"))
        {
            myyacht.SetActive(true);
            areayacht.SetActive(false);
            playerStickMan.SetActive(false);
            playerStash.SetActive(false);
            player.transform.position = new Vector3(60F, 3F, 58F);
            player.GetComponent<PlayerMove>().speed = 40;
        }

        if (other.CompareTag("Car"))
        {
            mycar.SetActive(true);
            areacar.SetActive(false);
            playerStickMan.SetActive(false);
            playerStash.SetActive(false);
            player.GetComponent<PlayerMove>().speed = 30;
        }

    }


    public void ExitYacth()
    {
        myyacht.SetActive(false);
        areayacht.SetActive(true);
        this.transform.position = new Vector3(29F, 0F,59.2F);
        playerStickMan.SetActive(true);
        playerStash.SetActive(true);
        player.GetComponent<PlayerMove>().speed = 20;
    }

    public void ExitCar()
    {
        mycar.SetActive(false);
        areacar.SetActive(true);
        areacar.transform.position = new Vector3(this.transform.position.x + 5, 2.452207F, this.transform.position.z);
        playerStickMan.SetActive(true);
        playerStash.SetActive(true);
        player.GetComponent<PlayerMove>().speed = 20;
    }
}
