using UnityEngine;
using Wind.Core;

namespace Wind.Motor
{
    public class VortexMotor : MonoBehaviour
    {
        public float Force;
        public float Radius;
        void OnEnable()
        {
            WindSimulationCore.Instance.AddMotorVortexMotor(this);
        }

        void OnDisable()
        {
            WindSimulationCore.Instance.RemoveMotorVortexMotor(this);
        }

        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(this.transform.position, this.Radius);
            Gizmos.DrawRay(this.transform.position, this.transform.forward);
        }
    }
}
