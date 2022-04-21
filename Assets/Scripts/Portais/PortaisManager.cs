using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaisManager : MonoBehaviour
{
    //Precisa de um script de load/Carregamento
    public string Scene;
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Scene);
        }
    }

}
