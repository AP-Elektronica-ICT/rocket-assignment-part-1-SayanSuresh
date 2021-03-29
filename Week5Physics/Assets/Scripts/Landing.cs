using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Landing : MonoBehaviour
{
    public string mLevelToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Load the new level (mLevelLoad)
            SceneManager.LoadScene(mLevelToLoad);
        }
    }
}
