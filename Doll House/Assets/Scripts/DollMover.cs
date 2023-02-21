using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMover : MonoBehaviour
{
    public GameObject[] dolls;
    public GameObject[] dollSpawnPoints;
    public string[] locations;


    public void move(GameObject doll, string location)
    {
        GameObject[] tempList;
        tempList = GameObject.FindGameObjectsWithTag(location);
        int random = Random.Range(0, tempList.Length);  
        GameObject temp = tempList[random];
        doll.transform.position = new Vector3(temp.transform.position.x, temp.transform.position.y, temp.transform.position.z);
    }
    public void moveRandomLocation(GameObject doll)
    {
        string location = locations[Random.Range(0,locations.Length)];
        GameObject[] tempList;
        tempList = GameObject.FindGameObjectsWithTag(location);
        int random = Random.Range(0, tempList.Length);
        GameObject temp = tempList[random];
        doll.transform.position = new Vector3(temp.transform.position.x, temp.transform.position.y, temp.transform.position.z);
    }

    public void moveRandom()
    {
        GameObject doll = dolls[Random.Range(0, dolls.Length)];
        string location = locations[Random.Range(0, locations.Length)];
        GameObject[] tempList;
        tempList = GameObject.FindGameObjectsWithTag(location);
        int random = Random.Range(0, tempList.Length);
        GameObject temp = tempList[random];
        doll.transform.position = new Vector3(temp.transform.position.x, temp.transform.position.y, temp.transform.position.z);
    }

}

