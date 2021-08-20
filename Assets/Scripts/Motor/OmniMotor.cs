using UnityEngine;
using Wind.Core;

namespace Wind.Motor
{
    public class OmniMotor : MonoBehaviour
    {
        public float Force;
        public float radius;
        void OnEnable()
        {
            WindSimulationCore.Instance.AddMotorOmni(this);
        }

        void OnDisable()
        {
            WindSimulationCore.Instance.RemoveMotorOmni(this);
        }

        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(this.transform.position,this.radius);
        }
    }
}
