using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;

    // Use this for initialization
    //void Start () {

    void OnTriggerEnter(Collider other)
    {
        //look thorugh children for exisiting icon
        foreach(Transform child in inventoryPanel.transform)
        {
            //if item already in inventory
            if (child.gameObject.tag == other.gameObject.tag)
        {
            string c = child.Find("Text").GetComponent<Text>().text;
            int tcount = System.Int32.Parse(c) + 1;
            child.Find("Text").GetComponent<Text>().text = "" + tcount;
            return;

        }
    }

    GameObject i;
    if (other.gameObject.CompareTag ("gear"))
        {
            i = Instantiate(inventoryIcons[0]);
            i.transform.SetParent(inventoryPanel.transform);
        }
    else if(other.gameObject.CompareTag ("wrench"))
        {
           i = Instantiate(inventoryIcons[1]);
           i.transform.SetParent(inventoryPanel.transform);
    }
    else if(other.gameObject.CompareTag ("piston"))
        {
            i = Instantiate(inventoryIcons[2]);
            i.transform.SetParent(inventoryPanel.transform);
    }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
