using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoBehaviour
{
    public GameObject spikePrefab;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f,0f,-5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z<-21f)//behind camera
        {
            //get all roads
            RoadScript[] roads = FindObjectsOfType<RoadScript>();
            //find the one in the back
            float highestZ=0;
            RoadScript backRoad=roads[0];
            foreach(RoadScript road in roads)//loop all roads
            {
                if(road.transform.position.z>highestZ)//check if the road we found is firther than the last one
                {
                    highestZ = road.transform.position.z;
                    backRoad = road;
                }
            }
            //teleport behind the back road
            transform.position = backRoad.transform.position+new Vector3(0f,0f,24f);

            for(int i=0;i<transform.childCount;i++)//remove all things attached to the road
            {
                Destroy(transform.GetChild(i).gameObject);
            }
            //spawn new things and attach to road
            float chance=Random.Range(0f, 100f);
            if(chance<50f)
            {
                GameObject spike = Instantiate(spikePrefab, transform.position + new Vector3(Random.Range(-7f, 7f), 2f, 0f), Quaternion.Euler(90f,0f,0f));
                spike.transform.SetParent(transform);
            }

        }
        
    }
}
