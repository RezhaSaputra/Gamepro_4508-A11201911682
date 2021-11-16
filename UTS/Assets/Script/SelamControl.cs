using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelamControl : MonoBehaviour
{
    public float aksi;
    
    Vector3 keatas;
    Vector3 kebawah;

    int score = 0;
    float speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0, -1, 0);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up")){
            transform.position = transform.position + (keatas * speed * Time.deltaTime);
        }else if (Input.GetKey("down")){
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);
        }
         Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0) {
            Die ();
        }
        
    }
    void Die() {
            Debug.Log ("game over");
            SceneManager.LoadScene ("Menu");
            
        }

        void OnCollisionEnter2D(Collision2D coll) {
            Die ();
        }
    
}
