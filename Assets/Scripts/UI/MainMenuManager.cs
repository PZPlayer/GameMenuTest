using UnityEngine;

namespace PP5.UI
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _entryMenu;
        [SerializeField] private GameObject _pressStartMenu;

        private bool canPressStart = false;


        private void Update()
        {
            if(canPressStart && Input.anyKey)
            {
                _pressStartMenu.GetComponent<Animator>().SetTrigger("Pressed");
                canPressStart = false;
            }
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
