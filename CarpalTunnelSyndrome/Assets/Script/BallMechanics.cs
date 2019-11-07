using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMechanics : MonoBehaviour
{
    public int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 1) { count = 1; }
        if (count >= 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.SetActive(false);
            }
        }

            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == gameObject.GetComponent<MeshRenderer>().material.color)
        {
                count++;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == gameObject.GetComponent<MeshRenderer>().material.color)
        {
            if (other.gameObject.GetComponent<BallMechanics>().count > count)
                count = other.gameObject.GetComponent<BallMechanics>().count;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == gameObject.GetComponent<MeshRenderer>().material.color)
        {
            int otherCount = other.gameObject.GetComponent<BallMechanics>().count;
            if (otherCount > 1)
                count -= otherCount;
            else
                count--;
        }
            
    }

}
