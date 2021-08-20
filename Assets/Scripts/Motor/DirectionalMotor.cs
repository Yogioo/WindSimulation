using UnityEngine;
using Wind.Common;
using Wind.Core;

namespace Wind.Motor
{
    public class DirectionalMotor : MonoBehaviour
    {
        public float Force;
        public float ForceWave = 2;

        
        private float m_InitForce;
        public float Radius = 1;

        void OnEnable()
        {
            m_InitForce = Force;
            WindSimulationCore.Instance.AddMotorDirectional(this);
        }

        void Update()
        {
            Force = m_InitForce + Random.Range(-ForceWave, ForceWave)*Time.deltaTime;

        }

        void OnDisable()
        {
            WindSimulationCore.Instance.RemoveMotorDirectional(this);
        }

        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(this.transform.position, Radius);
        }
    }
}
