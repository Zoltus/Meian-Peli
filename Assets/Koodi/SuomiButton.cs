using UnityEngine;
using UnityEngine.UI;

namespace Autopeli
{
    public class SuomiButton : MonoBehaviour {
        private void Start() {
            handleShadows();
        }
        public void changeLanguage() {
            Debug.Log("Changed to fi");
            LanguageManager.SetLanguage(0);
            handleShadows();
        }

        public static void handleShadows() {
            var fi = GameObject.Find("Suomi").GetComponent<Image>();
            var eng = GameObject.Find("Englanti").GetComponent<Image>();
            var language = LanguageManager.getLanguage();
            if (language == 0) {
                Debug.Log("Suomi");
                fi.color = new Color(1, 1, 1);
                eng.color = new Color(0.5f, 0.5f, 0.5f);
            } else {
                Debug.Log("enkku");
                eng.color = new Color(1, 1, 1);
                fi.color = new Color(0.5f, 0.5f, 0.5f);
            }
        }
    }
}
