using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdvance : MonoBehaviour
{
    
    public string nextSceneName;

    public void LoadNextScene()
        
    {

    SceneManager.LoadScene(nextSceneName);

    }
  }
    
    
        
    

