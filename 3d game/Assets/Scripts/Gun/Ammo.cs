
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{

        public static int CurrentAmmo;
        public int InternalAmmo;
        public GameObject AmmoDisplay;

        void Update()
        {
            InternalAmmo = CurrentAmmo;
            AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        }
    }



