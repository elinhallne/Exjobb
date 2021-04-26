using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Fungus
{
    /// <summary>
    /// Sets parameter value for target AudioMixer.
    /// </summary>
    [CommandInfo("Audio",
                 "Set Mixer Parameter",
                 "Sets parameter value for target AudioMixer.")]
    [AddComponentMenu("")]
    public class AudioFromFungus: Command
    {
        [Tooltip("Target AudioMixer")]
        [SerializeField]
        protected AudioMixer mixer = null;

        [Tooltip("Name of exposed parameter")]
        [SerializeField]
        protected string parameterName = "";

        [Tooltip("New float value of the parameter")]
        [SerializeField] protected float parameterValue = 0f;

        public override void OnEnter()
        {
            mixer.SetFloat(parameterName, parameterValue);

            Continue();
        }

        public override string GetSummary()
        {
            if (mixer == null)
            {
                return "No target mixer selected";
            }

            return "Set " + parameterValue + " of " + mixer.name + " to " + parameterValue;
        }

        public override Color GetButtonColor()
        {
            return new Color32(242, 209, 176, 255);
        }
    }
}

