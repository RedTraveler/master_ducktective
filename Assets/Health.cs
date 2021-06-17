using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float vidas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

        //att=attack
        void OnTriggerEnter(Collider col)
        {
            // vc já deve saber, mas o q está nas aspas é uma tag aleatória para o inimigo mude para o q quiser.
            if (col.tag == "Enemy")
            {
                vidas = vidas -1;

                if (vidas <= 0)
                {// se o personagem tiver uma animação de morte acho q é para insiri-la aqui.
                    Destroy(gameObject);
                }

            }
        }
    
}
