using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //int lane = 0;
    public float damage;
    public Transform spawn;
    public LayerMask mask;
    public float sensibility = 5;
    public GameObject gameOver, BGM;
    // Update is called once per frame

    public Vector3 posInicial;
    public Vector3 posActual;
    public float difX;
    void FixedUpdate()
    {


        if (Input.GetMouseButtonDown(0))
        {
            posInicial = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            posActual = Input.mousePosition;
            difX = posActual.x - posInicial.x;
            float newZ = Mathf.Clamp((transform.position.z + difX) * sensibility, -3f, 3f);
            this.transform.position = new Vector3(transform.position.x, transform.position.y, newZ /*Input.mousePosition.x*//* * sensibility / 1000*/);
        }


        RaycastHit hit;
        if (Physics.Raycast(spawn.position, transform.right * -1, out hit, Mathf.Infinity, mask))
        {
            Debug.Log("Hit object: " + hit.collider.name + " with tag: " + hit.collider.tag);
            if (hit.collider.CompareTag("Enemy"))
            {
                Debug.Log("bang");
                hit.collider.GetComponent<EnemyManager>().enemyHealth -= damage;
                Debug.Log(hit.collider.GetComponent<EnemyManager>().enemyHealth);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            gameOver.SetActive(true);
        }
    }
}
