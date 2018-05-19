using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sine
{
    [CreateAssetMenu(menuName = "Sine/Event", fileName = "New Event")]
    public class Event : ScriptableObject
    {
        public List<Track> tracks; 
    }
}

