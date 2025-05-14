using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SectionTrigger : MonoBehaviour
{
    public GameObject[] roadSection = new GameObject[4];
    public GameObject bossSection;
    public int waveCounter;
    public int uiWaveCount;
    public TMPro.TextMeshProUGUI waves;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger") && waveCounter < 10)
        {
            Instantiate(roadSection[Random.Range(0,4)], new Vector3(-12, 0, 0), Quaternion.identity);
            waveCounter++;
        }
        else if(other.gameObject.CompareTag("Trigger") && waveCounter >= 10)
        {
            Instantiate(bossSection, new Vector3(-12, 0, 0), Quaternion.identity);
            waveCounter = 0;
        }
    }
}
