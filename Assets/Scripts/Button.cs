using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextScene;
    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
