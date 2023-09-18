using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
    public int FuerzaDeSalto;
    public int VelocidadDeMov;
    bool EnElPiso = false;

    // Start is called before the first frame update
    void Start() {

    }
    
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space") && EnElPiso)
        {
            EnElPiso = false;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FuerzaDeSalto));
        }

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(VelocidadDeMov,
            this.GetComponent<Rigidbody2D>().velocity.y
            );

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnElPiso = true;
        if(collision.gameObject.tag== "Obstaculo")
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnElPiso = true;
        if (collision.gameObject.tag== "Obstaculo")
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    


}
