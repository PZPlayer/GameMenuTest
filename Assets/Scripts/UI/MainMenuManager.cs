using UnityEngine;

namespace PP5.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _entryMenu;
        [SerializeField] private GameObject _pressStartMenu;

        [SerializeField] private AudioClip _pressSound;
        [SerializeField] private AudioClip _pointOnButtonSound;

        private bool canPressStart = false;
        
        private AudioSource audioSource;

        void Start ()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if(canPressStart && Input.anyKey)
            {
                OnPressAnyButton();
            }
        }

        private void OnPressAnyButton()
        {
            _pressStartMenu.GetComponent<Animator>().SetTrigger("Pressed");
            audioSource.PlayOneShot(_pressSound);
            canPressStart = false;
        }

        public void HideEntr()
        {
            _entryMenu.SetActive(false);
            canPressStart = true;
        }

        public void HidePressStartMenu()
        {
            _pressStartMenu.SetActive(false);
        }
    }
}
