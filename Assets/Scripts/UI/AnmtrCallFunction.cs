using Unity.VisualScripting;
using UnityEngine;

namespace PP5.UI
{
    public class AnmtrCallFunction : MonoBehaviour
    {
        [SerializeField] private MainMenuManager _mMenuManager;
        [SerializeField] private AudioClip _soundHighLightPlay;
        [SerializeField] private AudioClip _soundPressPlay;
        [SerializeField] private GameObject _hidePanel;

        public void HideEntryMenu()
        {
            _mMenuManager.HideEntr();
        }

        public void HidePanel()
        {
            if(!_hidePanel) return;
            _hidePanel.SetActive(false);
        }

        public void HidePressStartMenu()
        {
            _mMenuManager.HidePressStartMenu();
        }

        public void PlayHighlightSound()
        {
            transform.GetComponent<AudioSource>().PlayOneShot(_soundHighLightPlay);
        }

        public void PlayPressSound()
        {
            transform.GetComponent<AudioSource>().PlayOneShot(_soundPressPlay);
        }
    }
}
