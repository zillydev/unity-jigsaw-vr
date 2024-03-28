using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject _plane;
    [SerializeField]
    private GameObject _gridPlane;
    [SerializeField]
    private GameObject _imagePlane;
    // [SerializeField]
    // private GameObject _text;

    // private int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_plane, new Vector3(0, 0, 0), Quaternion.identity);
        int index = 1;
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Vector3 pos = new Vector3(-0.5f + (i*0.52f), 1.7f + (j*(-0.52f)), 2);
                GameObject gridPlane = Instantiate(_gridPlane, pos, Quaternion.identity);
                gridPlane.transform.rotation = Quaternion.Euler(90, 180, 0);
                gridPlane.GetComponent<BoxCollider>().size = new Vector3(10f, 12f, 10f);
                gridPlane.name = "" + index;
                gridPlane.tag = "GridPlane";
                Vector3 pos2 = new Vector3(2f + (i*0.52f), 1.7f + (j*(-0.52f)), 2);
                GameObject imagePlane = Instantiate(_imagePlane, pos2, Quaternion.identity);
                imagePlane.transform.rotation = Quaternion.Euler(90, 180, 0);
                Texture2D texture1 = LoadTexture("Assets/Textures/image_part_00" + index + ".jpg");
                Material material1 = new Material(Shader.Find("Unlit/Texture"));
                material1.mainTexture = texture1;
                imagePlane.GetComponent<Renderer>().material = material1;
                index++;
            }
        }
        
        
    }

    Texture2D LoadTexture(string path) {
        byte[] fileData;
        fileData = System.IO.File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(fileData);
        return texture;
    }

    // public void increase() {
    //     number++;
    //     Debug.Log(number);
    //     if (number >= 9) {
    //         _text.SetActive(true);
    //     }
    // }
}
