using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DesignPatterns.Observer
{

    public class ClickCounterObserver : MonoBehaviour
    {
        [SerializeField] ButtonSubject m_SubjectToObserve;

        private int m_ClickCount = 0;

        private void Awake()
        {
            if (m_SubjectToObserve != null)
            {
                m_SubjectToObserve.Clicked += OnThingHappened;
            }
        }

        private void OnThingHappened()
        {
            m_ClickCount++;
            Debug.Log("Button has been clicked " + m_ClickCount + " times.");
        }

        private void OnThingHappened(ButtonSubject buttonSubject)
        {
            OnThingHappened();
        }

        private void OnDestroy()
        {
            // unsubscribe/deregister from the event if we destroy the object
            if (m_SubjectToObserve != null)
            {
                m_SubjectToObserve.Clicked -= OnThingHappened;
            }
        }

    }
}
