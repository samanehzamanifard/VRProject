using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Generate_ChangeColor : MonoBehaviour
{
     public GameObject Prefab_Sphere;	
	public Color col;

    public PathType pathSystem = PathType.CatmullRom;
    public Vector3[] pathVal1 = new Vector3[2];
    public Vector3[] pathVal2 = new Vector3[2];
    public Vector3[] pathVal3 = new Vector3[2];

    float y1 = 13.72f;
    float y2 = 8.72f;
    float y3 = 3.72f;
    public int duration = 4;
    // Start is called before the first frame update
    void Start()
    {
		
		for(int i = 1; i < 23; i++){
			for(int j = 0; j < 3; j++){
				Prefab_Sphere = Instantiate(Prefab_Sphere, new Vector3((19.1f + i-0.2f),(13.72f - (5 * j)),28.79f), Quaternion.identity) as GameObject;
				int rand = Random.Range (0,3);
				if(rand == 1){
					col = Color.red;
				}
				else if(rand == 0){
					col = Color.blue;
				}
				else if(rand == 2){
					col = Color.green;
				}
				else{
					col = Color.black;
				}
				Prefab_Sphere.GetComponent<MeshRenderer>().material.color = col;
                /*if (Prefab_Sphere.transform.y == y1)
                {
                    Prefab_Sphere.transform.DOPath(pathVal1, duration, pathSystem);
                }
                else if (Prefab_Sphere.transform.y == y2)
                {
                    Prefab_Sphere.transform.DOPath(pathVal2, duration, pathSystem);
                }
                else if (Prefab_Sphere.transform.y == y3)
                {
                    Prefab_Sphere.transform.DOPath(pathVal3, duration, pathSystem);
                }*/
            }
		}
    }

}
