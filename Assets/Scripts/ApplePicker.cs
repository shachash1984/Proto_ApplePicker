using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketlist;

	// Use this for initialization
	void Start () {

        basketlist = new List<GameObject>();

        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketlist.Add(tBasketGO);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            
            Destroy(tGO);
        }

        int basketIndex = basketlist.Count - 1;
        GameObject tBasketGO = basketlist[basketIndex];
        basketlist.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        if (basketlist.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }
}
