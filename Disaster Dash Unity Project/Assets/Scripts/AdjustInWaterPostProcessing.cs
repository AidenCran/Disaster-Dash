using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using Cycle2AidensWork;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date:
    /// Last Edited:
    /// 
    /// 
    /// </summary>
    public class AdjustInWaterPostProcessing : MonoBehaviour
    {
        public static AdjustInWaterPostProcessing instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        public PostProcessProfile Profile;
        private Vignette Vg;

        private ColorParameter Colour;

        private void Start()
        {
            Vg = Profile.GetSetting<Vignette>();
        }

        public void ToggleVignette(bool Toggle)
        {
            Vg.active = true;
        }

        public void modifyColour()
        {
            Colour.value = new Color(0f,0f,0f);
            Vg.color = Colour;
        }
    }
}
