using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
<<<<<<< HEAD

    void Start()
    {
        CollectibleControl.ResetCoinCount();
=======
    
    void Start()
    {
        
>>>>>>> origin/main
    }

    void Update()
    {
<<<<<<< HEAD

=======
        
>>>>>>> origin/main
    }

    public void PlayGame()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("Scene1");
=======
        SceneManager.LoadScene(1);
>>>>>>> origin/main
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
