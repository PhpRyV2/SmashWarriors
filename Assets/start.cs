using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public PlayerMovement player;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.gameObject.SetActive(false);
            player.BGM.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
