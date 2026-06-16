using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
    public class ProductC : MonoBehaviour, IProduct
    {
        [SerializeField]
        private string m_ProductName = "ProductC";
        public string ProductName { get => m_ProductName; set => m_ProductName = value; }

        private Renderer m_Renderer;

        public void Initialize()
        {
            gameObject.name = m_ProductName;
            m_Renderer = GetComponent<Renderer>();
            m_Renderer.material.color = Random.ColorHSV();

            if (m_Renderer == null)
                return;
        }
    }
}

