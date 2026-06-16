using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DesignPatterns.Factory
{
    public class ConcreteFactoryC : Factory
    {
        // Used to create a Prefab
        [SerializeField]
        private ProductC m_ProductPrefab;

        public override IProduct GetProduct(Vector3 position)
        {
            // Create a Prefab instance and get the product component
            GameObject instance = Instantiate(m_ProductPrefab.gameObject, position, Quaternion.identity);
            ProductC newProduct = instance.GetComponent<ProductC>();

            // Each product contains its own logic
            newProduct.Initialize();

            return newProduct;
        }
    }
}
