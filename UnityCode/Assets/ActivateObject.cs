using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActivateObject : MonoBehaviour
{

    ParticleSystem ps;
    ParticleSystem.EmissionModule psemit;

    private GameObject Manish;
    //public GameObject Message;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        psemit = ps.emission;
        Manish = GameObject.Find("Manish");
       // Message = GameObject.Find("message");
       // Message.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
           //Message.SetActive(true);
            if (!ps.isPlaying)
            {
               // Message.SetActive(true);
                ps.Simulate(0.0f, true, true);
                psemit.enabled = true;
                ps.Play();
               
            }
        }
        else
        {
            if (ps.isPlaying)
            {
                psemit.enabled = false;
                ps.Stop();
            }
        }
       
        

        if (Input.GetKeyDown(KeyCode.N))
        {
             GameObject.DestroyObject(Manish);

        }


       


    }

}





