using UnityEngine;
using UnityEngine.SceneManagement;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date:
    /// Last Edited:
    /// 
    /// 
    /// </summary>
    public class ChangeScene : MonoBehaviour
    {
        public static ChangeScene instance;

        public void ButtonSound()
        {
            FindObjectOfType<AudioManager>().Play("MenuSelect");
        }

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }
        public void changeSceneFunction(string SceneName)
        {
            SceneManager.LoadSceneAsync(SceneName);
        }
        public void quitGame()
        {
            Application.Quit();
        }
    }
}
